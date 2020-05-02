using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Models
{
    public class DetalleFacturas
    {
        [Key]
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
       
        public DetalleFacturas()
        {
            DetalleFacturaId = 0;
            FacturaId = 0;
            ProductoId = 0;
            NombreProducto = string.Empty;
            Cantidad = 0;
            Precio = 0;

        }

        public DetalleFacturas(int detalleFacturaID, int facturaID, int productoID, int cantidad, decimal precio)
        {
            this.DetalleFacturaId = detalleFacturaID;
            this.FacturaId = facturaID;
            this.ProductoId = productoID;
            this.Cantidad = cantidad;
            this.Precio = precio;

        }
    }
}
