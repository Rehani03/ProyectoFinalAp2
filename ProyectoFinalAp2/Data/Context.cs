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
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = CooasarDb; Trusted_Connection = True; ");
            //optionsBuilder.UseSqlServer(@"Server=tcp:cooasar-projectdbserver.database.windows.net,1433;Initial Catalog=COOASAR-PROJECT_db;Persist Security Info=False;User ID=Administrador-Rico;Password=Asdfghjkl05;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }


        public DbSet<Clientes> Clientes {get; set;}
        public DbSet<Categorias> Categorias { get; set; }

    }
}
