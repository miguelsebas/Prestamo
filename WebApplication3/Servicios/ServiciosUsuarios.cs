using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class ServiciosUsuarios
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public void InsertarUsuario(Models.Usuario userVM)
        {
            var newUser = new Models.Usuario()
            {
                ApyNom =userVM.ApyNom,
                DNI = userVM.DNI,
                Celular = userVM.Celular,
                Domicilio = userVM.Domicilio,
                IdZona = userVM.IdZona,
                Usuario1 = userVM.Usuario1,
                Password = userVM.Password,
                Status = 1
            };
            db.Usuarios.Add(newUser);
            db.SaveChanges();
        }

        public void EditarUsuario(Models.Usuario userVM)
        {
            var EditUser = db.Usuarios.Find(userVM.Id);
            EditUser.ApyNom = userVM.ApyNom;
            EditUser.Celular = userVM.Celular;
            EditUser.DNI = userVM.DNI;
            EditUser.Domicilio = userVM.Domicilio;
            EditUser.Usuario1 = userVM.Usuario1;
            EditUser.Password = userVM.Password;
            EditUser.IdZona = userVM.IdZona;

            db.Entry(EditUser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void BorrarUsuario(long id)
        {
            var BorrarUser = db.Usuarios.Find(id);
            BorrarUser.Status = 0;

            db.Entry(BorrarUser).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<Usuario> traerTodosUsuarios()
        {
            var list = db.Usuarios.Where(x => x.Status == 1);
            return list.ToList();
        }
        public Usuario traerPorId(long id)
        {
            var user = db.Usuarios.Find(id);
            return user;
        }
        public Usuario traerPorNombreYApellido(string cadena)
        {
            var clienteVM = db.Usuarios.Where(x => x.ApyNom == cadena || x.ApyNom.Contains(cadena)
            || x.DNI == cadena && x.Status == 1).FirstOrDefault();
            return clienteVM;
        }

        public IEnumerable<Usuario> traerPorUsuariosPorZona(long idZona)
        {
            var clienteVM = db.Usuarios.Where(x => x.IdZona == idZona && x.Status == 1);
            return clienteVM.ToList();
        }

    }
}