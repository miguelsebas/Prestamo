using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication3.Servicios
{
    public class ServiciosClientes
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public void InsertarCliente(ViewModels.ClienteVM clienteVM)
        {
            var newCliente = new Models.Cliente();
            newCliente.ApyNom = clienteVM.ApyNom;
            newCliente.Celular = clienteVM.Celular;
            newCliente.DNI = clienteVM.DNI;
            newCliente.Domicilio = clienteVM.Domicilio;
            newCliente.DomicilioSec = clienteVM.DomicilioSec;
            newCliente.Email = clienteVM.Email;
            newCliente.Fijo = clienteVM.TelefonoFijo;
            newCliente.Cartera = (float)clienteVM.Cartera;
            newCliente.IdZona = clienteVM.IdZona;
            newCliente.Status = 1;

            db.Clientes.Add(newCliente);
            db.SaveChanges();
        }

        public void EditarCliente(ViewModels.ClienteVM clienteVM)
        {
            var EditarCliente = db.Clientes.Find(clienteVM.Id);
            EditarCliente.ApyNom = clienteVM.ApyNom;
            EditarCliente.Celular = clienteVM.Celular;
            EditarCliente.DNI = clienteVM.DNI;
            EditarCliente.Domicilio = clienteVM.Domicilio;
            EditarCliente.DomicilioSec = clienteVM.DomicilioSec;
            EditarCliente.Email = clienteVM.Email;
            EditarCliente.Fijo = clienteVM.TelefonoFijo;
            EditarCliente.Cartera = (float)clienteVM.Cartera;
            EditarCliente.IdZona = clienteVM.IdZona;

            db.Entry(EditarCliente).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void BorrarCliente(long id)
        {
            var BorrarCliente = db.Clientes.Find(id);
            BorrarCliente.Status = 0;

            db.Entry(BorrarCliente).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<object> traerTodosClientes()
        {
            var list = db.Clientes.Where(x => x.Status == 1);
            return list.ToList();
        }
        public object traerPorId(long id)
        {
            var clienteVM = db.Clientes.Find(id);
            return clienteVM;
        }
        public object traerPorNombreYApellido(string cadena)
        {
            var clienteVM = db.Clientes.Where(x => x.ApyNom == cadena || x.ApyNom.Contains(cadena)
            ||x.DNI == cadena || x.Email == cadena && x.Status == 1);
            return clienteVM;
        }

        public IEnumerable<object> traerPorClientesPorZona(long idZona)
        {
            var clienteVM = db.Clientes.Where(x => x.IdZona == idZona && x.Status == 1);
            return clienteVM.ToList();
        }
    }
}