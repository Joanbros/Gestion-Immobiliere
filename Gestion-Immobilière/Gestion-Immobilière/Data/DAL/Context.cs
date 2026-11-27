using Gestion_Immobilière.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Immobilière.Data.DAL
{
    public class Context : DbContext
    {
        public DbSet<Bien> Biens { get; set; }
        public DbSet<Bail> Bails { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public DbSet<Pret> Prets { get; set; }
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }


        public Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder
    optionsBuilder)
        =>
        optionsBuilder.UseNpgsql("Host=localhost;Database=GestImmo;" +
            "Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Logement>().ToTable("Logement");
            modelBuilder.Entity<Maison>().ToTable("Maison");
            modelBuilder.Entity<Box>().ToTable("Box");
            modelBuilder.Entity<Appartement>().ToTable("Appartment");

        }
    }
}
