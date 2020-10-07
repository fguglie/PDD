using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace TrabajoPractico
{
    public class TPDBContext : DbContext
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
    }
}
