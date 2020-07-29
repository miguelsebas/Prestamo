using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ZonaController : Controller
    {
        Servicios.ServicioZona _servicioZona = new Servicios.ServicioZona();

        // GET: Zona
        public ActionResult Index()
        {
            var list = _servicioZona.traerTodasZona();                        
            
            if (list.Count() != 0)
            {
                return View(list);
            }
            else
            {
                return View();
            }
        }

        // GET: Zona/Details/5
        public ActionResult Details(long id)
        {
            var detalles = _servicioZona.traerPorId(id);
            return View(detalles);
        }

        // GET: Zona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zona/Create
        [HttpPost]
        public ActionResult Create(Models.Zona zonaVM)
        {
            try
            {
                _servicioZona.InsertarZona(zonaVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zona/Edit/5
        public ActionResult Edit(long id)
        {
            var zonaEditar = _servicioZona.traerPorId(id);
            return View(zonaEditar);
        }

        // POST: Zona/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Zona zonaVM)
        {
            try
            {
                _servicioZona.EditarZona(zonaVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Zona/Delete/5
        public ActionResult Delete(long id)
        {
            var borrarZona = _servicioZona.traerPorId(id);
            return View(borrarZona);
        }

        // POST: Zona/Delete/5
        [HttpPost]
        public ActionResult Delete(Models.Zona zonaVM)
        {
            try
            {
                _servicioZona.BorrarZona(zonaVM.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
