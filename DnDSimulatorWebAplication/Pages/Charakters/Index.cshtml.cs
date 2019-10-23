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
    public class IndexModel : PageModel
    {
        private readonly DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext _context;

        public IndexModel(DnDSimulatorWebAplication.Models.DnDSimulatorWebAplicationContext context)
        {
            _context = context;
        }

        public IList<Charakter> Charakter { get;set; }

        public async Task OnGetAsync()
        {
            Charakter = await _context.Charakter.ToListAsync();
        }
    }
}
