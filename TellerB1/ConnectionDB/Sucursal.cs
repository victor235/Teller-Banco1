using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Sucursal
    {
        int id;
        string ubicacion;
        string provincia;

        public int Id { get => id; set => id = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Provincia { get => provincia; set => provincia = value; }
    }
}
