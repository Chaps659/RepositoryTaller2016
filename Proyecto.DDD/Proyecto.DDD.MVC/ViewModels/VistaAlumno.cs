using Proyecto.DDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto.DDD.MVC.ViewModels
{
    public class VistaAlumno 
    {
        [Key]
        public int PersonaID { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Rellenar")]
        [MaxLength(150, ErrorMessage = "Maximo de caracteres")]
        [MinLength(2, ErrorMessage = "Minimo de caracteres")]
        public string Foto { get; set; }

    }
}