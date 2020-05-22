using Entidades;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Data
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"DataSource= Data\ButterSoftDB.db");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Categorias>().HasData(new Categorias
            {
                CategoriaId = 1,
                Descripcion = "CALZADOS"
            });
        }

        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<EntradaProductos> EntradaProductos { get; set; }
        public DbSet<Clientes> Clientes {get; set;}
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<DetalleEntradaProductos> DetalleEntradaProductos { get; set; }
    }
}
