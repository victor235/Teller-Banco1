using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TellerB1
{
    public partial class aCajero : Form
    {
        public aCajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCajero agregar = new AgregarCajero();
            agregar.ShowDialog();
        }
    }
}
