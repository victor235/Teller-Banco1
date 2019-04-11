using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Cajas
    {
        int id;
        string descripcion;
        EstadoCaja estado;
        decimal balance;
        Sucursal sucursal;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public EstadoCaja Estado { get => estado; set => estado = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public Sucursal Sucursal { get => sucursal; set => sucursal = value; }

        public Caja_AppEntities5 ActualizarBalance(Caja_AppEntities5 teller)
        {
            teller.tblCajas.Find(id).Balance = balance;
            return teller;
        }
    }

    public enum EstadoCaja { Cerrada, Abierta};
}
