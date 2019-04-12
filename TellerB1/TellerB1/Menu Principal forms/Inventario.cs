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
    public partial class Inventario : Form
    {
        DataManager datamanager = new DataManager();
        Usuario cajero;

        public Inventario(Usuario usuario)
        {
            InitializeComponent();
            cajero = usuario;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CompletarDtgv();
            MostrarBalance();
        }

        void CompletarDtgv()
        {
            DataTable Data = datamanager.InventarioDataTable(cajero.Caja.Id);
            dtgvDenominaciones.DataSource = Data;
            dtgvDenominaciones.Columns[1].ReadOnly = true;
            dtgvDenominaciones.Columns[2].ReadOnly = true;
            dtgvDenominaciones.AllowUserToAddRows = false;
        }

        void MostrarBalance()
        {
            int total = 0;
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }
            tbBalance.Text = total.ToString();
        }
    }
}
