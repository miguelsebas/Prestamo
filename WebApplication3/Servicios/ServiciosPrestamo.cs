using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Servicios
{
    public class ServiciosPrestamo
    {
        Models.PrestamosEntities db = new Models.PrestamosEntities();

        public float? CalcularIntereses(long id, DateTime fecha, float interes)
        {
            var cliente = db.Clientes.Find(id);
            var prestamo = db.Prestamos.Where(x => x.IdCliente == cliente.Id && x.Fecha == fecha).FirstOrDefault();
            var interesCuota = prestamo.Monto * interes;

            return interesCuota;
        }

        public void InsertarPrestamos(Models.Prestamo prestamo)
        {
            float? montoInteres = 0;
            float? montoCuota = 0;
            var nuevoPrestamo = new Models.Prestamo();
            nuevoPrestamo = prestamo;
            montoInteres = nuevoPrestamo.Monto * (nuevoPrestamo.Interes/100);
            montoCuota = (nuevoPrestamo.Monto / nuevoPrestamo.Cuotas ) + montoInteres;
            generarCuotas(nuevoPrestamo.IdTipoCuota, nuevoPrestamo.IdTipoInteres, nuevoPrestamo.Cuotas, montoCuota, nuevoPrestamo.Id);
            db.Prestamos.Add(nuevoPrestamo);
            db.SaveChanges();
        }
        public void generarCuotas(long? idTipoCuota, long? idTipoInteres,int? numeroCuotas, float? monto, long idPrestamo)
        {
            if (idTipoCuota == 1)
            {
                
                for (int i = 0; i < numeroCuotas; i++)
                {                
                    var nuevaCuota = new Models.Cuota();
                    nuevaCuota.Fecha = DateTime.Now.AddDays(i); new CultureInfo("es-ES");
                    nuevaCuota.EstaPagado = 0;
                    nuevaCuota.IdPrestamo = idPrestamo;
                    var montoCuo = Math.Round((double)monto, 2);
                    nuevaCuota.Valor = (float)montoCuo;

                    db.Cuotas.Add(nuevaCuota);
                                      
                }
                db.SaveChanges();
            }
            else if (idTipoCuota == 2)
            {
                var fecha = DateTime.Now;
                for (int i = 0; i < numeroCuotas; i++)
                {
                    var nuevaCuota = new Models.Cuota();
                    nuevaCuota.Fecha = fecha;
                    nuevaCuota.EstaPagado = 0;
                    nuevaCuota.IdPrestamo = idPrestamo;
                    nuevaCuota.Valor = monto;

                    db.Cuotas.Add(nuevaCuota);                    
                    fecha.AddDays(7);
                }
                db.SaveChanges();
            }
            else if (idTipoCuota == 3)
            {
                var fecha = DateTime.Now;
                for (int i = 0; i < numeroCuotas; i++)
                {
                    var nuevaCuota = new Models.Cuota();
                    nuevaCuota.Fecha = fecha;
                    nuevaCuota.EstaPagado = 0;
                    nuevaCuota.IdPrestamo = idPrestamo;
                    nuevaCuota.Valor = monto;

                    db.Cuotas.Add(nuevaCuota);                    
                    fecha.AddDays(15);
                }
                db.SaveChanges();
            }
            else if (idTipoCuota == 4)
            {
                var fecha = DateTime.Now;
                for (int i = 0; i < numeroCuotas; i++)
                {
                    var nuevaCuota = new Models.Cuota();
                    nuevaCuota.Fecha = fecha;
                    nuevaCuota.EstaPagado = 0;
                    nuevaCuota.IdPrestamo = idPrestamo;
                    nuevaCuota.Valor = monto;

                    db.Cuotas.Add(nuevaCuota);                    
                    fecha.AddMonths(1);
                }
                db.SaveChanges();
            }
        }

    }
}