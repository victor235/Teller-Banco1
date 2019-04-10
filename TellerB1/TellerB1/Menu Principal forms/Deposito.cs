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
using Processor;

namespace TellerB1
{
    public partial class Deposito : Form
    {
        ClsProcessor processor = new ClsProcessor();
        LocalCliente clienteActivo;

        public Deposito()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificarCuenta_Click(object sender, EventArgs e)
        {
            string cuenta = tbVerificarCuenta.Text;
            
            
            LocalCliente cliente = processor.VerificarCliente(cuenta);
            if (cliente.Apellidos != null)
            {
                tbClienteVerificado.Text = cliente.Nombres + cliente.Apellidos;
                tbCuentaVerificada.Text = cliente.Codigo;
                tbCuenta.Text = cliente.Codigo;
                clienteActivo = cliente;
            }
            else
            {
                MessageBox.Show("La cuenta ingresada no existe");
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

            decimal monto;
            LocalConfirmacion confirmacion = new LocalConfirmacion();
            LocalDeposito deposito = new LocalDeposito();

            if (!decimal.TryParse(tbMonto.Text, out monto))
                MessageBox.Show("El monto ingresado no es valido");
            else
            {
                deposito.Monto = monto;
                deposito.Cuenta = clienteActivo;
                deposito.Fecha = DateTime.Now;
                confirmacion = processor.RealizarDeposito(deposito);
                MessageBox.Show(confirmacion.mensajeConfirmación);
            }
        }

        private void tbCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCedula_Click(object sender, EventArgs e)
        {

        }
    }
}
