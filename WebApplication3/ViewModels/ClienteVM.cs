using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class ClienteVM
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Display(Name ="Nombre y Apellido")]
        public string ApyNom { get; set; }
        [Required]
        public string Domicilio { get; set; }
        [Display(Name = "Domicilio Secundario")]
        public string DomicilioSec { get; set; }
        [Required]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string DNI { get; set; }
        [Required]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string Celular { get; set; }
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        public string TelefonoFijo { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public double Cartera { get; set; }

        public long IdPrestamo { get; set; }
        public long IdZona { get; set; }
    }
}