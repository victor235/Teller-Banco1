using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Bancos
    {
        int id;
        string descripcion;

        public Bancos(int id)
        {
            this.id = id;
            if (id == 1)
                this.descripcion = "Banco 1";
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
