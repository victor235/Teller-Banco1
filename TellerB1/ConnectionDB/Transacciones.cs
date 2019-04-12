using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Transacciones
    {
        int id;
        TipoTransaccion tipo;
        decimal monto;
        string cuenta;
        Cajas caja;
        Usuario cajero;
        Bancos banco;
        DateTime fecha;

        public Transacciones() { }
        public Transacciones(TipoTransaccion tipo, decimal monto, string cuenta, Cajas caja, Usuario cajero, Bancos banco, DateTime fecha)
        {
            this.tipo = tipo;
            this.monto = monto;
            this.cuenta = cuenta;
            this.caja = caja;
            this.cajero = cajero;
            this.banco = banco;
            this.fecha = fecha;
        }

        public int Id { get => id; set => id = value; }
        public TipoTransaccion Tipo { get => tipo; set => tipo = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public Cajas Caja { get => caja; set => caja = value; }
        public Usuario Cajero { get => cajero; set => cajero = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Bancos Banco { get => banco; set => banco = value; }


        public Caja_AppEntities6 GuardarTransaccion(Caja_AppEntities6 teller)
        {
            tblTransaccion transaccion = new tblTransaccion();
            transaccion.Banco = banco.Id;
            transaccion.Caja = caja.Id;
            transaccion.Monto = monto;
            transaccion.Tipo = Convert.ToInt32(tipo)+1;
            transaccion.Cuenta = cuenta;
            transaccion.Cajero = cajero.Codigo_Usuario;
            transaccion.Fecha = fecha;

            teller.tblTransaccion.Add(transaccion);
            return teller;
        }


    }

    public enum TipoTransaccion {Retiro, Deposito, Retiro_Interbancario, Deposito_Interbancario}
}
