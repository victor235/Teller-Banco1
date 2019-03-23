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


namespace TellerB1
{
    public partial class LogIn1 : Form
    {
        public LogIn1()
        {
            InitializeComponent();
            
        }   
            
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int user;
            if (!int.TryParse(tbUser.Text, out user))
                MessageBox.Show("Los codigos de usuario solo pueden contener caracteres numericos");
            else
            {
                string password = tbPassword.Text;
                string tipo = cmbTipoUser.SelectedValue.ToString();
                TipoUsuario tipoUsuario;

                if (tipo == TipoUsuario.Administrador.ToString())
                    tipoUsuario = TipoUsuario.Administrador;
                else
                    tipoUsuario = TipoUsuario.Cajero;

                Usuario usuario = new Usuario(user, password, tipoUsuario);

                string message = usuario.ValidarUsuario();
                foreach (Control textbox in Controls)
                {
                    if (textbox is TextBox)
                        textbox.Text = "";
                }
                MessageBox.Show(message);

                if (usuario.Valido)
                {
                    if (usuario.Tipo == TipoUsuario.Administrador)
                    {
                        this.Hide();
                        MenuAdministrar form = new MenuAdministrar(usuario);
                        form.Show();
                        
                    }
                    else
                    {
                        this.Hide();
                        MenuP form = new MenuP(usuario);
                        form.Show();
                        
                    }
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
