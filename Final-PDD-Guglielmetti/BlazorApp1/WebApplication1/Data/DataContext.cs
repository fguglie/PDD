using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary1.Data;

namespace WebApplication1.Data
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            modelBuilder.Entity<Tarea>().ToTable("Tarea");

            modelBuilder.Entity<Recurso>().ToTable("Recurso");

            modelBuilder.Entity<Detalle>().ToTable("Detalle");
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Detalle> Detalles { get; set; }

    }
}
