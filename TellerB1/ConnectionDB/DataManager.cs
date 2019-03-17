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

        public string[] Password(int id)
        {
            string[] datos = new string[2];
            int count=0;

            Command.Connection = Connection.OpenConnection();
            Command.CommandText = ConfigurationManager.AppSettings["PasswordById"];
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Codigo_Usuario", id);
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                datos[0] = Reader[0].ToString();
                datos[1] = Reader[1].ToString();
                count++;
            }
            
            Command.Parameters.Clear();
            return datos;
        }
    }
}
