using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Čajevi.Models;

namespace Čajevi.Models
{
    public class čajeviContext : DbContext
    {
        public čajeviContext (DbContextOptions<čajeviContext> options)
            : base(options)
        {
        }

        public DbSet<Čajevi.Models.Biljni> Biljni { get; set; }

        public DbSet<Čajevi.Models.Voćni> Voćni { get; set; }

        public DbSet<Čajevi.Models.Premium> Premium { get; set; }

        public DbSet<Čajevi.Models.SpecialEdition> SpecialEdition { get; set; }
    }
}
