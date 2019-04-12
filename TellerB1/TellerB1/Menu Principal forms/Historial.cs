using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace TellerB1
{
    public partial class Historial : Form
    {
        DataManager datamanager = new DataManager();
        Usuario cajero;

        public Historial(Usuario usuario)
        {
            InitializeComponent();
            cajero = usuario;
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarUltimas();
        }

        void CargarUltimas()
        {
            dtgvTransacciones.DataSource = datamanager.Transacciones(cajero, BuscarFechaCuadre(), DateTime.Now);
        }

        DateTime BuscarFechaCuadre()
        {
            Cuadre cuadre = new Cuadre();
            cuadre.Cajero = cajero;

            return cuadre.BuscarFechaInicio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            
            dtgvTransacciones.DataSource= datamanager.Transacciones(cajero, desde, hasta);
        }
    }
}
