using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ConnectionDB
{
    public class DataManager
    {
        private ConnectionDB Connection = new ConnectionDB();
        private SqlCommand Command = new SqlCommand();
        private SqlDataReader Reader;

        public string[] DatosUsuario(int id)
        {
            string[] datos = new string[5];
            

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
            return datos;
        }
    }
}
