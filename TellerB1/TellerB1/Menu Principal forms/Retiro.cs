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
    public partial class Retiro : Form
    {
        Usuario usuario;
        ClsProcessor processor;
        LocalCliente clienteActivo;
        LocalRetiro retiro;
        DataManager datamanager = new DataManager();
        decimal montoRetiro;

        public Retiro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Retiro_Load(object sender, EventArgs e)
        {
            ConexionIntegrador();
            CompletarDtgv();
        }

        void CompletarDtgv()
        {
            DataTable Data = datamanager.LLenarFilas();

            dtgvDenominaciones.DataSource = Data;
            dtgvDenominaciones.Columns[2].ReadOnly = true;
            dtgvDenominaciones.AllowUserToAddRows = false;
        }

        private void dtgvDenominaciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal monto;
            decimal valor = Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[0].Value);

            if (dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value.GetType() == typeof(DBNull))
            {
                dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value = 0;
            }
            int cant = Convert.ToInt32(dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value);

            if (!usuario.Caja.CantidadDisponible(cant, valor))
            {
                dtgvDenominaciones.Rows[e.RowIndex].Cells[1].Value = 0;
                MessageBox.Show("No se dispone de esa cantidad en el inventario de efectivo", "Cantidad no valida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cant = 0;
            }

            monto = cant * valor;
            dtgvDenominaciones.Rows[e.RowIndex].Cells[2].Value = monto;
            CompararMontoRetiro();
        }

        private void dtgvDenominaciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show("La columna \"Cantidad\" solo admite valores numericos", "Error Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(e.Exception.Message);
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

        private void btnVerificarCuenta_Click(object sender, EventArgs e)
        {
            string cedula = tbVerificarCuenta.Text;


            LocalCliente cliente = processor.VerificarCedula(cedula);
            if (cliente.Apellidos != null)
            {
                tbClienteVerificado.Text = cliente.Nombres + cliente.Apellidos;
                tbCuentaVerificada.Text = cliente.Codigo;
                tbCuenta.Text = cliente.Codigo;
                clienteActivo = cliente;
            }
            else
            {
                MessageBox.Show("La cedula ingresada no corresponde a ninguna cuenta");
            }
            HabilitarRetiro();
        }

        private void HabilitarRetiro()
        {
            decimal monto;
            decimal efectivo;
            if (tbCuenta.Text != string.Empty && tbMonto.Text != string.Empty)
            {
                monto = decimal.Parse(tbMonto.Text);
                if (monto == 0)
                {
                    btnRetiro.Enabled = false;
                    return;
                }
                if (!decimal.TryParse(tbEfectivo.Text, out efectivo))
                {
                    efectivo = 0;
                }

                if (monto == efectivo)
                {
                    btnRetiro.Enabled = true;
                    return;
                }
                else
                {
                    btnRetiro.Enabled = false;
                    return;
                }
            }
            else
            {
                btnRetiro.Enabled = false;
                return;
            }
            
        }

        void CompararMontoRetiro()
        {
            decimal total = 0;
            decimal monto = decimal.Parse(tbMonto.Text);
            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }

            tbEfectivo.Text = total.ToString();

            if (total < monto)
            {
                btnRetiro.Enabled = false;
                return;
            }
            else if (total > monto)
            {
                btnRetiro.Enabled = false;
                return;
            }
            else
            {
                HabilitarRetiro();
            }

        }

        private void tbMonto_Leave(object sender, EventArgs e)
        {
            CompletarDtgv();
            tbEfectivo.Clear();
            DtgvEnable();
            HabilitarRetiro();
        }

        void DtgvEnable()
        {
            if (tbMonto.Text == string.Empty)
            {
                dtgvDenominaciones.Enabled = false;
                return;
            }

            if (!decimal.TryParse(tbMonto.Text, out decimal monto))
            {
                MessageBox.Show("Por favor ingrese una cantidad numerica", "Error de Monto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtgvDenominaciones.Enabled = true;
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            decimal monto;
            LocalConfirmacion confirmacion = new LocalConfirmacion();
            retiro = new LocalRetiro();

            if (!decimal.TryParse(tbMonto.Text, out monto))
                MessageBox.Show("El monto ingresado no es valido");
            else
            {
                retiro.Monto = monto;
                retiro.Cuenta = new LocalCliente();
                retiro.Cuenta.Nombres = "Juan";
                retiro.Cuenta.Apellidos = "Perez";
                retiro.Cuenta.Codigo = tbCuenta.Text;
                //retiro.Cuenta = clienteActivo; en lo que llega Gabriel
                retiro.Fecha = DateTime.Now;
                confirmacion = processor.RealizarRetiro(retiro);
                EvaluarConfirmacion(confirmacion);
            }
        }

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
            Transacciones transaccion = new Transacciones(TipoTransaccion.Retiro, retiro.Monto, retiro.Cuenta.Codigo,
                usuario.Caja, usuario, new Bancos(1), retiro.Fecha);

            teller = transaccion.GuardarTransaccion(teller);
            return teller;
        }
        Caja_AppEntities6 GuardarInventarios(Caja_AppEntities6 teller)
        {
            List<Inventarios> inventarios = new List<Inventarios>();

            foreach (DataGridViewRow row in dtgvDenominaciones.Rows)
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
            usuario.Caja.Balance -= retiro.Monto;
            teller = usuario.Caja.ActualizarBalance(teller);
            return teller;
        }
    }
}
