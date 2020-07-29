using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class UsuariosController : Controller
    {
        Servicios.ServiciosUsuarios _servicioUsuarios = new Servicios.ServiciosUsuarios();
        Servicios.ServicioZona _serviciosZona = new Servicios.ServicioZona();
        // GET: Usuarios
        public ActionResult Index()
        {
            var list = _servicioUsuarios.traerTodosUsuarios();
            return View(list);
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(long id)
        {
            var user = _servicioUsuarios.traerPorId(id);
            return View(user);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            var list = _serviciosZona.traerTodasZona();
            ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Models.Usuario userVM)
        {
            try
            {
                var list = _serviciosZona.traerTodasZona();
                ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
                _servicioUsuarios.InsertarUsuario(userVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(long id)
        {
            var list = _serviciosZona.traerTodasZona();
            ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
            var editUser = _servicioUsuarios.traerPorId(id);
            return View(editUser);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Usuario userVM)
        {
            try
            {
                var list = _serviciosZona.traerTodasZona();
                ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
                _servicioUsuarios.EditarUsuario(userVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(long id)
        {
            var list = _serviciosZona.traerTodasZona();
            ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
            var borrarUser = _servicioUsuarios.traerPorId(id);
            return View(borrarUser);
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(Models.Usuario userVM)
        {
            try
            {
                var list = _serviciosZona.traerTodasZona();
                ViewBag.ListaZona = new SelectList(list, "Id", "Descripcion");
                _servicioUsuarios.BorrarUsuario(userVM.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
