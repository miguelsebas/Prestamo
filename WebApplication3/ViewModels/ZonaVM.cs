using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class ZonaVM
    {
        public long Id { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}