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

        public int Id { get => id; set => id = value; }
        public decimal Balance_inicial { get => balance_inicial; set => balance_inicial = value; }
        public decimal Balance_final { get => balance_final; set => balance_final = value; }
        public DateTime Fecha_apertura { get => fecha_apertura; set => fecha_apertura = value; }
        public DateTime Fecha_cierre { get => fecha_cierre; set => fecha_cierre = value; }
        public Cajas Caja { get => caja; set => caja = value; }
        public Usuario Cajero { get => cajero; set => cajero = value; }
    }
}
