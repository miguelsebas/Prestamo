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
        // GET: Clientes
        public ActionResult Index()
        {
            var list = _serviciosClientes.traerTodosClientes();
            return View(list);
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
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(ViewModels.ClienteVM clienteVM)
        {
            try
            {
                _serviciosClientes.InsertarCliente(clienteVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(long id)
        {
            var editCliente = _serviciosClientes.traerPorId(id);
            return View(editCliente);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(ViewModels.ClienteVM clienteVM)
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
        public ActionResult Delete(ViewModels.ClienteVM clienteVM)
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
