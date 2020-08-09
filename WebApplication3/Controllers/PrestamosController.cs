using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class PrestamosController : Controller
    {
        Servicios.ServiciosClientes _serviciosClientes = new Servicios.ServiciosClientes();
        Servicios.ServicioTipoInteres _servicioTipoInteres = new Servicios.ServicioTipoInteres();
        Servicios.ServiciosPrestamo _serviciosPrestamo = new Servicios.ServiciosPrestamo();
        // GET: Prestamos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prestamos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prestamos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prestamos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prestamos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prestamos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Prestamos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prestamos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult CrearPrestamoConCliente(long id)
        {
            var cliente = _serviciosClientes.traerPorId(id);
            ViewBag.IdZona = cliente.IdZona;
            var listaInteres = _servicioTipoInteres.traerInteres(); 
            var listaCuotas = _servicioTipoInteres.traerCuotas();
            ViewBag.TipoInteres = new SelectList(listaInteres, "Id", "Descripcion");
            ViewBag.TipoCuotas = new SelectList(listaCuotas, "Id", "Descripcion");
            ViewBag.ClienteId = cliente.Id;
            ViewBag.Cliente = cliente.ApyNom;
            return View();
        }
        [HttpPost]
        public ActionResult CrearPrestamoConCliente(Models.Prestamo prestamo)
        {
            _serviciosPrestamo.InsertarPrestamos(prestamo);
            return RedirectToAction("Index");
        }
    }
}
