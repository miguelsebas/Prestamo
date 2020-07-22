using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Servicios
{
    public class ServiciosUsuarios
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public void InsertarUsuario(ViewModels.Usuario userVM)
        {
            var newUser = new Models.Usuario()
            {
                ApyNom =userVM.ApyNom,
                DNI = userVM.DNI,
                Celular = userVM.Celular,
                Domicilio = userVM.Domicilio,
                IdZona = userVM.IdZona,
                Usuario1 = userVM.User,
                Password = userVM.Password,
                Status = 1
            };
            db.Usuarios.Add(newUser);
            db.SaveChanges();
        }

        public void EditarUsuario(ViewModels.Usuario userVM)
        {
            var EditUser = db.Usuarios.Find(userVM.Id);
            EditUser.ApyNom = userVM.ApyNom;
            EditUser.Celular = userVM.Celular;
            EditUser.DNI = userVM.DNI;
            EditUser.Domicilio = userVM.Domicilio;
            EditUser.Usuario1 = userVM.User;
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

        public IEnumerable<object> traerTodosUsuarios()
        {
            var list = db.Usuarios.Where(x => x.Status == 1);
            return list.ToList();
        }
        public object traerPorId(long id)
        {
            var clienteVM = db.Usuarios.Find(id);
            return clienteVM;
        }
        public object traerPorNombreYApellido(string cadena)
        {
            var clienteVM = db.Usuarios.Where(x => x.ApyNom == cadena || x.ApyNom.Contains(cadena)
            || x.DNI == cadena && x.Status == 1);
            return clienteVM;
        }

        public IEnumerable<object> traerPorUsuariosPorZona(long idZona)
        {
            var clienteVM = db.Usuarios.Where(x => x.IdZona == idZona && x.Status == 1);
            return clienteVM.ToList();
        }

    }
}