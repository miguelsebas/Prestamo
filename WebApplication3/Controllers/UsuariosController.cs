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
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(ViewModels.Usuario userVM)
        {
            try
            {
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
            var editUser = _servicioUsuarios.traerPorId(id);
            return View(editUser);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(ViewModels.Usuario userVM)
        {
            try
            {
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
            var borrarUser = _servicioUsuarios.traerPorId(id);
            return View(borrarUser);
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(ViewModels.Usuario userVM)
        {
            try
            {
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
