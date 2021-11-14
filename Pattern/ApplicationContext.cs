using Microsoft.EntityFrameworkCore;
using Pattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    class ApplicationContext : DbContext
    {
        public DbSet<Amphibian> Amphibians { get; set; }
        public DbSet<Bird> Birds { get; set; }
        public DbSet<Mammal> Mammals { get; set; }


        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MVPDB;Trusted_Connection=True;");
        }
    }
}
