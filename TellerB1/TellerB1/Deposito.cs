﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mensajes;
using Processor;

namespace TellerB1
{
    public partial class Deposito : Form
    {
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
            
            ClsProcessor processor = new ClsProcessor();
            LocalCliente cliente = processor.VerificarCliente(cuenta);
            if (cliente.Apellidos != null)
            {
                tbClienteVerificado.Text = cliente.Nombres + cliente.Apellidos;
                tbCuentaVerificada.Text = cliente.Codigo;
                tbCuenta.Text = cliente.Codigo;
            }
            else
            {
                MessageBox.Show("La cuenta ingresada no existe");
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            //Validaciones
            decimal monto;
            if (!tbCuenta.Text.Any())
            {
                MessageBox.Show("No ha ingresado ninguna cuenta");
                return;
            }
            if (!decimal.TryParse(tbMonto.Text, out monto))
            {
                MessageBox.Show("El monto ingresado no es valido");
                return;
            }

            //Declaraciones, asignaciones e instancias
            string cuenta;
            cuenta = tbCuenta.Text;
            
            ClsProcessor processor = new ClsProcessor();
            LocalCliente cliente = new LocalCliente(cuenta);
            LocalDeposito deposito = new LocalDeposito(cliente, monto);
            LocalConfirmacion confirmacion = new LocalConfirmacion();

            //Procesos
            confirmacion = processor.RealizarDeposito(deposito);
          
            
        }
    }
}
