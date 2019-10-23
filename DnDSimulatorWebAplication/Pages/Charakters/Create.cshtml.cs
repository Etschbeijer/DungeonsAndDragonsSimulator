using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DnDSimulator.Model;
using DnDSimulatorWebAplication.Models;

namespace DnDSimulatorWebAplication.Pages.Charakters
{
    public class CreateModel : PageModel
    {
        private readonly DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext _context;

        public CreateModel(DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Charakter Charakter { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Charakter.Add(Charakter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}