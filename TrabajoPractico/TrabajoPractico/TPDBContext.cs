using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TrabajoPractico
{
    class TPDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=TP.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios");

            modelBuilder.Entity<Detalles>()
                .ToTable("Detalles");

            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos");

            modelBuilder.Entity<Tareas>()
                .ToTable("Tareas");

        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Detalles> Detalles { get; set; }

    }
}
