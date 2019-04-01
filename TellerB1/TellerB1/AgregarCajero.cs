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
using System.Data.SqlClient;
using System.Configuration;
using DataModel;



namespace TellerB1
{
    public partial class AgregarCajero : Form
    {
        public AgregarCajero()
        {
            InitializeComponent();
        }

        private void AgregarCajero_Load(object sender, EventArgs e)
        {

        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            string nombre = txtbNombre.Text;
            string apellido = txtbApellido.Text;
            int user;
            string password = txtbPassword.Text;


            if (!int.TryParse(txtbUser.Text, out user))
            {
                MessageBox.Show("Codigo de usuario no valido");
                return;
            }
            
            TipoUsuario tipoUsuario;
            tipoUsuario = TipoUsuario.Cajero;

            Usuario cajero = new Usuario(nombre, apellido, user, password, tipoUsuario);

            string query = "INSERT INTO tblUsuarios(Codigp_Usuario, Apellidos, Nombres, Contraseña. Tipo)";
            query += " VALUES (user, apellido, nombre, password, tipoUsuario)";
            
            //SqlConnection sqlConnection = new SqlConnection();
            //SqlCommand command = new SqlCommand(query, sqlConnection);

            //command.Parameters.AddWithValue(nombre, txtbNombre.Text);
            //command.Parameters.AddWithValue(apellido, txtbApellido.Text);
            //command.Parameters.AddWithValue(user, txtbUser.Text);
            //command.Parameters.AddWithValue(password, txtbPassword.Text);
            //command.Parameters.AddWithValue(tipoUsuario.ToString(), TipoUsuario.Cajero);
            //command.ExecuteNonQuery();
        }
    }
}
