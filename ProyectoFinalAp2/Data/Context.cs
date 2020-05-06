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
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = ButterSoftDb2; Trusted_Connection = True; ");
        }


        public DbSet<Clientes> Clientes {get; set;}
        public DbSet<Categorias> Categorias { get; set; }

    }
}
