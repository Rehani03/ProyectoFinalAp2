using Entidades;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalAp2.Data;
using ProyectoFinalAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Controllers
{
    public class EntradaProductoBLL
    {
        public static bool Guardar(EntradaProductos entity)
        {
            bool modificado = true;
            return modificado;
        }

        public static bool Modificar(EntradaProductos entity)
        {
            bool modificado = true;
            return modificado;
        }

        public static EntradaProductos Buscar(int ID)
        {
            EntradaProductos entradaProductos = new EntradaProductos();
            return entradaProductos;
        }

        public static bool Eliminar(int ID)
        {
            bool eliminado = true;
            return eliminado;
        }
    }
}
