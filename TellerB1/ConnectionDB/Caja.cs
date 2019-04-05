using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Caja
    {
        int id;
        string descripcion;
        Usuario cajero = new Usuario();
        bool estado;
        decimal balance;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Usuario Cajero { get => cajero; set => cajero = value; }
        public bool Estado { get => estado; set => estado = value; }
        public decimal Balance { get => balance; set => balance = value; }
    }
}
