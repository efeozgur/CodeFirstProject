using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models.Managers
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Unvanlar> Unvanlar { get; set; }
        public DbSet<Kisiler> Kisiler { get; set; }

        public DbSet<Birimler> Birimler { get; set; }

    }
}