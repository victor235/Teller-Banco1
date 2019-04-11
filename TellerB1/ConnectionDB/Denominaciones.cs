using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Denominaciones
    {
        int id;
        decimal valor;
        TipoDenominaciones tipo;
        string moneda;

        public Denominaciones() { }
        public Denominaciones(decimal valor)
        {
            this.valor = valor;
        }

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public TipoDenominaciones Tipo { get => tipo; set => tipo = value; }
        public string Moneda { get => moneda; set => moneda = value; }
    }

    public enum TipoDenominaciones { Moneda, Billete};
}
