using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnDSimulator.Model;
using DnDSimulatorWebAplication.Models;

namespace DnDSimulatorWebAplication.Pages.Charakters
{
    public class EditModel : PageModel
    {
        private readonly DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext _context;

        public EditModel(DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Charakter Charakter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Charakter = await _context.Charakter.FirstOrDefaultAsync(m => m.Id == id);

            if (Charakter == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Charakter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharakterExists(Charakter.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CharakterExists(int id)
        {
            return _context.Charakter.Any(e => e.Id == id);
        }
    }
}
