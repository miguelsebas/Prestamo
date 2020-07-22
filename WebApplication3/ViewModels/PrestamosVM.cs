using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class PrestamosVM
    {
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public int Cuotas { get; set; }
        public double Interes { get; set; }
    }
}