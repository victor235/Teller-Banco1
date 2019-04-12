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
        Usuario usuario;
        ClsProcessor processor;
        LocalCliente clienteActivo;
        LocalDeposito deposito;
        DataManager datamanager = new DataManager();
        decimal montoDeposito;

        public Deposito(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            ConexionIntegrador();
            CompletarDtgv();
            CompletarDevueltaDtgv();
        }

        void ConexionIntegrador()
        {
            try
            {
                processor = new ClsProcessor();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Se produjo un error al intentar conectar con el servidor", "Error de servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MenuP menuP = new MenuP(usuario);
                menuP.Show();
                Parent.Parent.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Se produjo un error al intentar conectar con el servidor", "Error de servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos Botones

        private void btnCedula_Click(object sender, EventArgs e)
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
            HabilitarDeposito();
        }
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            decimal monto;
            LocalConfirmacion confirmacion = new LocalConfirmacion();
            deposito = new LocalDeposito();

            if (!decimal.TryParse(tbMonto.Text, out monto))
                MessageBox.Show("El monto ingresado no es valido");
            else
            {
                deposito.Monto = monto;
                deposito.Cuenta = new LocalCliente();
                deposito.Cuenta.Nombres = "Juan";
                deposito.Cuenta.Apellidos = "Perez";
                deposito.Cuenta.Codigo = tbCuenta.Text;
                //deposito.Cuenta = clienteActivo; en lo que llega Gabriel
                deposito.Fecha = DateTime.Now;
                confirmacion = processor.RealizarDeposito(deposito);
                EvaluarConfirmacion(confirmacion);
            }

        }

        #endregion

        #region Metodos y eventos de tabla de Denominaciones
        void CompletarDtgv()
        {
            DataTable Data = datamanager.LLenarFilas();
            
            dtgvDenominaciones.DataSource = Data;
            dtgvDenominaciones.Columns[2].ReadOnly = true;
            dtgvDenominaciones.AllowUserToAddRows = false;
            
        }
        void CompletarDevueltaDtgv()
        {
            DataTable Data = datamanager.LLenarFilas();

            dtgvDevuelta.DataSource = Data;
            dtgvDevuelta.Columns[2].ReadOnly = true;
            dtgvDevuelta.AllowUserToAddRows = false;
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
            PresentarMontoEfectivo();
        }
        private void dtgvDenominaciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("La columna \"Cantidad\" solo admite valores numericos", "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(e.Exception.Message);
        }

        private void dtgvDevuelta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal monto;
            decimal valor = Convert.ToInt32(dtgvDevuelta.Rows[e.RowIndex].Cells[0].Value);

            if (dtgvDevuelta.Rows[e.RowIndex].Cells[1].Value.GetType() == typeof(DBNull))
            {
                dtgvDevuelta.Rows[e.RowIndex].Cells[1].Value = 0;
            }
            int cant = Convert.ToInt32(dtgvDevuelta.Rows[e.RowIndex].Cells[1].Value);

            if(!usuario.Caja.CantidadDisponible(cant, valor))
            {
                dtgvDevuelta.Rows[e.RowIndex].Cells[1].Value = 0;
                MessageBox.Show("No se dispone de esa cantidad en el inventario de efectivo", "Cantidad no valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cant = 0;
            }

            monto = cant * valor;
            dtgvDevuelta.Rows[e.RowIndex].Cells[2].Value = monto;
            CompararMontoDevuelta();
        }

        private void dtgvDevuelta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("La columna \"Cantidad\" solo admite valores numericos", "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(e.Exception.Message);
        }
        #endregion

        #region Preparar Deposito
        void HabilitarDeposito()
        {
            if (montoDeposito == 0)
            {
                btnDeposito.Enabled = false;
                tabControl1.Enabled = false;
                return;
            }

            decimal efectivo;
            decimal devuelta;
            if (!decimal.TryParse(tbEfectivo.Text, out efectivo))
            {
                efectivo = 0;
            }
            if (!decimal.TryParse(tbRealDevuelta.Text, out devuelta))
            {
                devuelta = 0;
            }

            if (tbCuenta.Text != string.Empty && tbMonto.Text != string.Empty)
            {
                if (montoDeposito == (efectivo - devuelta))
                {
                    btnDeposito.Enabled = true;
                }
                else
                {
                    btnDeposito.Enabled = false;
                }
            }
            else
            {
                btnDeposito.Enabled = false;
                return;
            }
            
            
        }
        void PresentarMontoEfectivo()
        {
            int total = 0;
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }
            tbEfectivo.Text = total.ToString();
            EvaluarMontos();
        }
        #endregion

        #region Ejecutarse luego de realizar deposito
        
        void EvaluarConfirmacion(LocalConfirmacion confirmacion)
        {
            if (confirmacion.succeeded)
            {
                MessageBox.Show("Transaccion realizada exitosamente");
                Caja_AppEntities6 teller = new Caja_AppEntities6();
                
                teller = InstanciarTransaccion(teller);
                teller = GuardarInventarios(teller);
                teller = GuardarNuevoBalance(teller);

                datamanager.SaveChanges(teller);
            }
        }
        Caja_AppEntities6 InstanciarTransaccion(Caja_AppEntities6 teller)
        {
            Transacciones transaccion = new Transacciones(TipoTransaccion.Deposito, deposito.Monto, deposito.Cuenta.Codigo,
                usuario.Caja, usuario, new Bancos(1), deposito.Fecha);

            teller = transaccion.GuardarTransaccion(teller);
            return teller;
        }
        Caja_AppEntities6 GuardarInventarios(Caja_AppEntities6 teller)
        {
            List<Inventarios> inventarios = new List<Inventarios>();
            List<Inventarios> devueltas = new List<Inventarios>();
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                decimal denominacion = Convert.ToDecimal(row.Cells[0].Value);
                int cantidad = Convert.ToInt32(row.Cells[1].Value);

                if (cantidad != 0)
                {
                    inventarios.Add(new Inventarios(usuario.Caja, new Denominaciones(denominacion), cantidad));
                }
            }
            foreach (DataGridViewRow row in dtgvDevuelta.Rows)
            {
                decimal denominacion = Convert.ToDecimal(row.Cells[0].Value);
                int cantidad = Convert.ToInt32(row.Cells[1].Value) * (-1);

                if (cantidad != 0)
                {
                    inventarios.Add(new Inventarios(usuario.Caja, new Denominaciones(denominacion), cantidad));
                }
            }

            foreach (var inven in inventarios)
            {
                teller = inven.ActualizarInventario(teller);
            }

            return teller;
        }
        Caja_AppEntities6 GuardarNuevoBalance(Caja_AppEntities6 teller)
        {
            usuario.Caja.Balance += deposito.Monto;
            teller = usuario.Caja.ActualizarBalance(teller);
            return teller;
        }
        #endregion

        private void tbMonto_Leave(object sender, EventArgs e)
        {
            CompletarDtgv();
            CompletarDevueltaDtgv();
            tbEfectivo.Clear();
            tbDevuelta.Clear();
            tbRealDevuelta.Clear();
            DtgvEnable();
            EvaluarMontos();
        }

        void DtgvEnable()
        {
            if (tbMonto.Text == string.Empty)
            {
                montoDeposito = 0;
                tabControl1.Enabled = false;
                return;
            }

            if (!decimal.TryParse(tbMonto.Text, out montoDeposito))
            {
                MessageBox.Show("Por favor ingrese una cantidad numerica", "Error de Monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tabControl1.Enabled = true;
        }

        void EvaluarMontos()
        {
            
            decimal efectivo;
            decimal devuelta;
            if(!decimal.TryParse(tbEfectivo.Text, out efectivo))
            {
                efectivo = 0;
            }
            if (!decimal.TryParse(tbRealDevuelta.Text, out devuelta))
            {
                devuelta = 0;
            }

            if (montoDeposito == efectivo)
            {
                HabilitarDeposito();
                dtgvDevuelta.Enabled = false;
                
            }
            else if(montoDeposito > efectivo)
            {
                dtgvDevuelta.Enabled = false;
                btnDeposito.Enabled = false;

            }
            else
            {
                
                CalcularTotalDevuelta();
                CompararMontoDevuelta();
                dtgvDevuelta.Enabled = true;
                return;
            }
        }

        void CalcularTotalDevuelta()
        {
            decimal devuelta;
            decimal efectivo=decimal.Parse(tbEfectivo.Text);

            devuelta = efectivo - montoDeposito ;
            tbDevuelta.Text = devuelta.ToString();

        }

        void CompararMontoDevuelta()
        {
            decimal total = 0;
            decimal devuelta=decimal.Parse(tbDevuelta.Text);
            foreach (DataGridViewRow row in dtgvDevuelta.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }

            tbRealDevuelta.Text = total.ToString();

            if (total < devuelta)
            {
                btnDeposito.Enabled = false;
                return;
            }
            else if (total > devuelta)
            {
                btnDeposito.Enabled = false;
                return;
            }
            else
            {
                HabilitarDeposito();
            }
            
        }

        
    }
}
