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
    public partial class MenuP : Form
    {
        public MenuP(Usuario usuario)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void depositoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Deposito fdeposito = new Deposito();
            fdeposito.TopLevel = false;
            Panel1.Controls.Add(fdeposito);
            fdeposito.Show();
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Retiro fretiro = new Retiro();
            fretiro.TopLevel = false;
            Panel1.Controls.Add(fretiro);
            fretiro.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Inventario finventario = new Inventario();
            finventario.TopLevel = false;
            Panel1.Controls.Add(finventario);
            finventario.Show();
        }

        private void MenuP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void MenuP_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void pendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Pendientes fpendientes = new Pendientes();
            fpendientes.TopLevel = false;
            Panel1.Controls.Add(fpendientes);
            fpendientes.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Historial fhistorial = new Historial();
            fhistorial.TopLevel = false;
            Panel1.Controls.Add(fhistorial);
            fhistorial.Show();

        }

        private void cuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            Cuadre fcuadre = new Cuadre();
            fcuadre.TopLevel = false;
            Panel1.Controls.Add(fcuadre);
            fcuadre.Show();
        }

        private void depositoInterbancarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            // No se por que pero en esta parte me aparece que el form no existe y no me deja hacerele Show queda pendiente a arreglar
            
            
        }

        private void retiroInterbancarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel1.Controls.Clear();
            RetiroInt retiroInt = new RetiroInt();
            retiroInt.TopLevel = false;
            Panel1.Controls.Add(retiroInt);
            retiroInt.Show();
        }
    }
}
