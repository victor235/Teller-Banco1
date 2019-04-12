using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Cuadre
    {
        int id;
        decimal balance_inicial;
        decimal balance_final;
        DateTime fecha_apertura;
        DateTime fecha_cierre;
        Cajas caja;
        Usuario cajero;

        public Cuadre(decimal balance_inicial,  DateTime fecha_apertura,  Cajas caja, Usuario cajero)
        {
            this.balance_inicial = balance_inicial;
            this.fecha_apertura = fecha_apertura;
            this.caja = caja;
            this.cajero = cajero;
        }

        public Cuadre(decimal balance_final, DateTime fecha_cierre, Cajas caja)
        {
            this.balance_final = balance_final;
            this.fecha_cierre = fecha_cierre;
            this.caja = caja;
        }

        public int Id { get => id; set => id = value; }
        public decimal Balance_inicial { get => balance_inicial; set => balance_inicial = value; }
        public decimal Balance_final { get => balance_final; set => balance_final = value; }
        public DateTime Fecha_apertura { get => fecha_apertura; set => fecha_apertura = value; }
        public DateTime Fecha_cierre { get => fecha_cierre; set => fecha_cierre = value; }
        public Cajas Caja { get => caja; set => caja = value; }
        public Usuario Cajero { get => cajero; set => cajero = value; }

        public Caja_AppEntities6 GuardarCuadre(Caja_AppEntities6 teller)
        {
            tblCuadres cuadres = new tblCuadres();
            cuadres.Balance_Inicial = balance_inicial;
            cuadres.Fecha_Apertura = fecha_apertura;
            cuadres.Caja = caja.Id;
            cuadres.Cajero = cajero.Codigo_Usuario;

            teller.tblCuadres.Add(cuadres);

            return teller;
        }

        public Caja_AppEntities6 CerrarCuadre(Caja_AppEntities6 teller)
        {
            foreach (var cuadre in teller.tblCuadres.Where(x=>x.Caja==caja.Id && x.Fecha_Cierre==null && x.Balance_Final==null))
            {
                cuadre.Balance_Final = balance_final;
                cuadre.Fecha_Cierre = fecha_cierre;
            }

            return teller;
        }
    }
}
