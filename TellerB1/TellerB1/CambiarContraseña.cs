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
    public partial class CambiarContraseña : Form
    {
        Usuario usuario;

        public CambiarContraseña(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string nueva=tbNueva.Text;
            string repetida=tbRepetir.Text;

            if (nueva == repetida)
            {
                usuario.GuardarContraseñaNueva(nueva);
                MessageBox.Show("Contraseña cambiada exitosamente", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextbox();
                return;
            }
            Hide();
        }

        private void ClearTextbox()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }
    }
}
