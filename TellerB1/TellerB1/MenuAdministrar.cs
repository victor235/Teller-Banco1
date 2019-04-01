using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Processor;
using DataModel;

namespace TellerB1
{
    public partial class MenuAdministrar : Form
    {
        public MenuAdministrar(Usuario usuario)
        {
            InitializeComponent();
        }

        private void MenuAdministrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            aCajero facajero = new aCajero();
            facajero.TopLevel = false;
            Panel2.Controls.Add(facajero);
            facajero.Show();

        }

        private void manejoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            aInventario fainventario = new aInventario();
            fainventario.TopLevel = false;
            Panel2.Controls.Add(fainventario);
            fainventario.Show();

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel2.Controls.Clear();
            aHistorial fahistorial = new aHistorial();
            fahistorial.TopLevel = false;
            Panel2.Controls.Add(fahistorial);
            fahistorial.Show();
        }
    }
}
