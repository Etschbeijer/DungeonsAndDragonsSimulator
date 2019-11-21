using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DnDSimulator.Model;

namespace DnDSimulatorWebAplication.Models
{
    public class DnDSimulatorWebAplicationContext : DbContext
    {
        public DnDSimulatorWebAplicationContext (DbContextOptions<DnDSimulatorWebAplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Charakter> Charakter { get; set; }
    }
}
