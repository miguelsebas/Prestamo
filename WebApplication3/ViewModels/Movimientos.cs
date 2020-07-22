using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.ViewModels
{
    public class Movimientos
    {
        public long Id { get; set; }
        public double Ingreso { get; set; }
        public double Egreso { get; set; }
        public DateTime Fecha { get; set; }

        public long IdPrestamo { get; set; }

    }
}