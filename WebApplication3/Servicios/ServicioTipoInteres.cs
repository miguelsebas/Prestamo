using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Servicios
{
    public class ServicioTipoInteres
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public List<Models.TipoCuota> traerCuotas()
        {
            var listaCuotas = from d in db.TipoCuotas select d;
            return listaCuotas.ToList();
        }

        public List<Models.TipoIntere> traerInteres()
        {
            var listaInteres = from d in db.TipoInteres select d;
            return listaInteres.ToList();
        }

    }
}