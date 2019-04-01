using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DataModel
{
    public class DataManager
    {
        private ConnectionDB Connection = new ConnectionDB();
        private SqlCommand Command = new SqlCommand();
        private SqlDataReader Reader;

        public string[] DatosUsuario(int id)
        {
            //Declaraciones e Instancias
            Usuario usuario = new Usuario();
            string[] datos = new string[5];
            
            //Consulta en Base de Datos
            Command.Connection = Connection.OpenConnection();
            Command.CommandText = "tblUsuarios_GetById";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Codigo_Usuario", id);
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                datos[0] = Reader[0].ToString();
                datos[1] = Reader[1].ToString();
                datos[2] = Reader[2].ToString();
                datos[3] = Reader[3].ToString();
                datos[4] = Reader[4].ToString();
            }
            Command.Parameters.Clear();
            Command.Connection = Connection.CloseConnection();

            return datos;
        }

        public LocalConfirmacion AgregarCajero()
        {

            return new LocalConfirmacion(true);
        }
    }
}
