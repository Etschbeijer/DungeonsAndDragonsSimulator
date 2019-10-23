using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DnDSimulator.Model;
using DnDSimulatorWebAplication.Models;

namespace DnDSimulatorWebAplication.Pages.Charakters
{
    public class DetailsModel : PageModel
    {
        private readonly DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext _context;

        public DetailsModel(DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext context)
        {
            _context = context;
        }

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
    }
}
