using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class ServicioLogin
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public Usuario RetornarUsuario(string user)
        {
            var oUser = db.Usuarios.Where(x => x.Usuario1 == user).FirstOrDefault();
            return oUser;
        }

        public bool CheckPassword(Usuario user , string pass)
        {
            if (user.Password == pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}