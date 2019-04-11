using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Inventarios
    {
        int id;
        Cajas caja=new Cajas();
        Denominaciones denominacion= new Denominaciones();
        int cantidad;

        public Inventarios() { }
        public Inventarios(Cajas caja, Denominaciones denominacion, int cantidad)
        {
            this.caja = caja;
            this.denominacion = denominacion;
            this.cantidad = cantidad;
        }

        public int Id { get => id; set => id = value; }
        public Cajas Caja { get => caja; set => caja = value; }
        public Denominaciones Denominacion { get => denominacion; set => denominacion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Caja_AppEntities5 ActualizarInventario(Caja_AppEntities5 teller)
        {
            
            foreach (var inven in teller.tblInventario_Efectivo.Where(x=>x.Caja==caja.Id && x.tblDenominaciones.Valor==denominacion.Valor))
            {
                inven.Cantidad += cantidad;
            }

            return teller;
        }
    }
}
