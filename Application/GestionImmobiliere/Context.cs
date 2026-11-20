using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionImmobiliere
{
    public class Context : DbContext
    {
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Bail> Bails { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Pret> Prets { get; set; }

        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
        =>
        optionsBuilder.UseNpgsql("Host=localhost;Database=GestImmo;" +
            "Username=postgres;Password=postgres");
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }
}
