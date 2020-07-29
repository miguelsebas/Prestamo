using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ClientesController : Controller
    {
        Servicios.ServiciosClientes _serviciosClientes = new Servicios.ServiciosClientes();
        Servicios.ServicioZona _serviciosZona = new Servicios.ServicioZona();
        // GET: Clientes
        public ActionResult Index()
        {
            var list = _serviciosClientes.traerTodosClientes();
            if (list.Count() != 0)
            {
                return View(list);
            }
            else
            {
                return View();
            }

        }

        // GET: Clientes/Details/5
        public ActionResult Details(long id)
        {
            var editCliente = _serviciosClientes.traerPorId(id);
            return View(editCliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            var list = _serviciosZona.traerTodasZona();            
            ViewBag.ListaZona = new SelectList(list,"Id", "Descripcion");
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Models.Cliente clienteVM)
        {
            try
            {
                var list = _serviciosZona.traerTodasZona();
                ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
                _serviciosClientes.InsertarCliente(clienteVM);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(long id)
        {
            var list = _serviciosZona.traerTodasZona();
            ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
            var editCliente = _serviciosClientes.traerPorId(id);
            return View(editCliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Cliente clienteVM)
        {
            try
            {
                _serviciosClientes.EditarCliente(clienteVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(long id)
        {
            var deleteCliente = _serviciosClientes.traerPorId(id);
            return View(deleteCliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(Models.Cliente clienteVM)
        {
            try
            {
                _serviciosClientes.BorrarCliente(clienteVM.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
