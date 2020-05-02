using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Models
{
    public class Usuarios
    {
        [Key]
        [Required(ErrorMessage = "El campo Id no puede estar vacío.")]
        [Range(0, 1000000, ErrorMessage = "El campo Id no puede ser menor que cero ni mayor a 1000000.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo Nombre no puede estar vacío.")]
        [MinLength(3, ErrorMessage = "El Nombre es muy corto.")]
        [MaxLength(30, ErrorMessage = "Nombre Nombre muy largo.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El nombre de usuario no puede estar vacío.")]
        [MinLength(3, ErrorMessage = "El Nombre de usuario es muy corto.")]
        [MaxLength(30, ErrorMessage = "El Nombre de usuario es muy largo.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo Clave no puede estar vacío")]
        [MinLength(4, ErrorMessage = "La Clave es muy corta.")]
        [MaxLength(60, ErrorMessage = "La Clave es muy larga.")]
        public string PassWord { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "El campo fecha no puede estar vacío.")]
        [DisplayFormat(DataFormatString = "{0:dd,mm, yyyy}")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage = "El Nivel Usuario no puede estar vacío.")]
        public int Nivel { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            NombreUsuario = string.Empty;
            PassWord = string.Empty;
            FechaIngreso = DateTime.Now;
            Nivel = 0;
        }
    }
}
