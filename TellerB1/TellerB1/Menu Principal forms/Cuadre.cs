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
    public partial class Cuadre : Form
    {
        DataManager datamanager = new DataManager();
        Usuario cajero;
        public Cuadre(Usuario usuario)
        {
            InitializeComponent();
            cajero = usuario;
        }

        private void Cuadre_Load(object sender, EventArgs e)
        {

        }

        #region Metodos y Eventos de tabla de Inventario
        void CompletarDtgv()
        {
            DataTable Data = datamanager.DenominacionesDataTable();
            dtgvDenominaciones.DataSource = Data;
            dtgvDenominaciones.Columns[2].ReadOnly = true;
            dtgvDenominaciones.AllowUserToAddRows = false;
        }


        #endregion
    }
}
