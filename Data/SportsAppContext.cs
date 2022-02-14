#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsApp.Models;

namespace SportsApp.Data
{
    public class SportsAppContext : DbContext
    {
        public SportsAppContext (DbContextOptions<SportsAppContext> options)
            : base(options)
        {
        }

        public DbSet<SportsApp.Models.ManageProducts> ManageProducts { get; set; }

        public DbSet<SportsApp.Models.TechnicianManager> TechnicianManager { get; set; }

        public DbSet<SportsApp.Models.CustomerManager> CustomerManager { get; set; }

        public DbSet<SportsApp.Models.IncidentPage> IncidentPage { get; set; }
    }
}
