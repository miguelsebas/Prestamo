using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class ServicioZona
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public void InsertarZona(Models.Zona zonaVM)
        {
            var newZona = new Models.Zona()
            {
                Descripcion = zonaVM.Descripcion,
                Status = 1                
            };
            db.Zonas.Add(newZona);
            db.SaveChanges();
        }

        public void EditarZona(Models.Zona zonaVM)
        {
            var editarZona = db.Zonas.Find(zonaVM.Id);
            editarZona.Descripcion = zonaVM.Descripcion;

            db.Entry(editarZona).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void BorrarZona(long id)
        {
            var borrarZona = db.Zonas.Find(id);
            borrarZona.Status = 0;

            db.Entry(borrarZona).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Models.Zona> traerTodasZona()
        {
            var list = db.Zonas.Where(x => x.Status == 1);
            return list.ToList();
        }
        public Zona traerPorId(long id)
        {
            var zoneVM = db.Zonas.Find(id);
            return zoneVM;
        }
        public Zona traerPorDescripcion(string cadena)
        {
            var zoneVM = db.Zonas.Where(x => x.Descripcion == cadena || x.Descripcion.Contains(cadena) && x.Status == 1).FirstOrDefault();
            return zoneVM;
        }

    }
}