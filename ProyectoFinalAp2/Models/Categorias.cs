using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalAp2.Models
{
    public class Categorias
    {
        [Key]
        [Range(0,1000000, ErrorMessage ="El campo Id no puede ser menor a cero ni mayor a 1000000.")]
        [Required(ErrorMessage = "El campo Id debe ser numerico.")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage ="El campo Descripcón no puede estar vacio.")]
        [MinLength(2, ErrorMessage ="La Descripción es muy corta.")]
        [MaxLength(30, ErrorMessage = "La Descripción es muy larga.")]
        public string Descripcion { get; set; }
        

        public Categorias()
        {
            CategoriaId = 0;
            
            Descripcion = string.Empty;
        }
    }
}
