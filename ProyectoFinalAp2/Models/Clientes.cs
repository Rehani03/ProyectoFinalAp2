using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string RNC { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        
        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            RNC = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
            Fecha = DateTime.Now;
           
        }
    }
}
