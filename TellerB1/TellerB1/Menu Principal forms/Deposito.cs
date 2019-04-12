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

        public Deposito(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Deposito_Load(object sender, EventArgs e)
        {
            ConexionIntegrador();
            CompletarDtgv();
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
        private void dtgvDenominaciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int monto;
            if (dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value.GetType() == typeof(DBNull))
            {
                dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value = 0;
            }
            monto = Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value) * Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[0].Value);
            dtgvDenominaciones.Rows[e.RowIndex].Cells[2].Value = monto;
            PresentarMontoDeposito();
        }
        private void dtgvDenominaciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("La columna \"Cantidad\" solo admite valores numericos", "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(e.Exception.Message);
        }
        #endregion

        #region Preparar Deposito
        void HabilitarDeposito()
        {
            if (tbCuenta.Text != string.Empty && tbMonto.Text != string.Empty)
            {
                btnDeposito.Enabled = true;
            }
        }
        void PresentarMontoDeposito()
        {
            int total = 0;
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }
            tbMonto.Text = total.ToString();
            HabilitarDeposito();
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
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                decimal denominacion = Convert.ToDecimal(row.Cells[0].Value);
                int cantidad = Convert.ToInt32(row.Cells[1].Value);

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
    }
}
