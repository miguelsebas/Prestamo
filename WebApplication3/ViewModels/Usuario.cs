using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class Usuario
    {
        public long Id { get; set; }
        [Required]
        public string ApyNom { get; set; }
        [Required]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string DNI { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string Celular { get; set; }
        [Required]
        [Display(Name = "Usuario")]
        public string User { get; set; }
        [Required]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Zona Asignada")]
        public long IdZona { get; set; }

    }
}