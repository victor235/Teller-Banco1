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
    public partial class LogIn1 : Form
    {
        DataManager datamanager = new DataManager();

        public LogIn1()
        {
            InitializeComponent();
            
        }   
        
        void ClearTextbox()
        {
            foreach (var textbox in Controls.OfType<TextBox>())
            {
                textbox.Clear();
            }
        }

        void ErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int user;
            string password;
            Usuario usuario;

            if (!int.TryParse(tbUser.Text, out user))
            {
                ErrorMessage("Los codigos de usuario solo pueden contener caracteres numericos", "Log In");
                ClearTextbox();
                return;
            }
                
            password = tbPassword.Text;
            //string tipo = cmbTipoUser.SelectedValue.ToString();
            //TipoUsuario tipoUsuario;

            //if (tipo == TipoUsuario.Administrador.ToString())
            //    tipoUsuario = TipoUsuario.Administrador;
            //else
            //    tipoUsuario = TipoUsuario.Cajero;

            try
            {
                usuario = datamanager.DatosUsuario(user);
            }
            catch(Exception error)
            {
                ErrorMessage(error.Message, "Log In");
                ClearTextbox();
                return;
            }

            if (usuario.Contraseña==password)
            {
                if (!usuario.Activo)
                {

                }

                if (usuario.Tipo == TipoUsuario.Administrador)
                {
                    MenuAdministrar form = new MenuAdministrar(usuario);
                    form.Show();
                    Hide();
                }
                else
                {
                    MenuP form = new MenuP(usuario);
                    form.Show();
                    Hide();
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogIn1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'caja_AppDataSet.tblTiposDeUsuario' table. You can move, or remove it, as needed.
            this.tblTiposDeUsuarioTableAdapter.Fill(this.caja_AppDataSet.tblTiposDeUsuario);

        }
    }
}
