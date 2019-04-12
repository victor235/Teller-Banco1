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
    public partial class AbrirCaja : Form
    {
        DataManager datamanager = new DataManager();
        Usuario cajero;
        public AbrirCaja(Usuario usuario)
        {
            InitializeComponent();
            cajero = usuario;
        }

        private void Cuadre_Load(object sender, EventArgs e)
        {
            CompletarDtgv();
            MontoTotal();
        }

        #region Metodos y Eventos de tabla de Inventario
        void CompletarDtgv()
        {
            DataTable Data = datamanager.InventarioDataTable(cajero.Caja.Id);
            dtgvDenominaciones.DataSource = Data;
            dtgvDenominaciones.Columns[2].ReadOnly = true;
            dtgvDenominaciones.AllowUserToAddRows = false;
        }
        private void dtgvDenominaciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int monto;
            if (dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value.GetType() == typeof(DBNull))
            {
                dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value = 0;
            }
            monto = Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value) * Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[0].Value);
            dtgvDenominaciones.Rows[e.RowIndex].Cells[2].Value = monto;
            MontoTotal();
        }
        private void dtgvDenominaciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("La columna \"Cantidad\" solo admite valores numericos", "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(e.Exception.Message);
        }
        #endregion

        void MontoTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }
            tbBalance.Text = total.ToString();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            Caja_AppEntities6 teller = new Caja_AppEntities6();
            decimal total = Convert.ToDecimal(tbBalance.Text);
            cajero.Caja.Balance = total;
            teller = cajero.Caja.AbrirCaja(teller);
            teller = NuevoCuadre(teller);
            datamanager.SaveChanges(teller);

            MessageBox.Show("Caja abierta exitosamente");

            MenuP menuP = new MenuP(cajero);
            menuP.Show();
            Parent.Parent.Hide();
        }

        Caja_AppEntities6 NuevoCuadre(Caja_AppEntities6 teller)
        {
            Cuadre cuadre = new Cuadre(cajero.Caja.Balance, DateTime.Now, cajero.Caja, cajero);
            teller = cuadre.GuardarCuadre(teller);
            return teller;
        }
    }
}
