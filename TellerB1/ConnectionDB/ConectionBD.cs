using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ConnectionDB
{
    public class ConnectionDB
    {
        static private string ConnectionString = ConfigurationManager.ConnectionStrings[2].ConnectionString;

       
        public SqlConnection Connection= new SqlConnection(ConnectionString);

        public SqlConnection OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            return Connection;
        }

        public SqlConnection CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }

            return Connection;
        }
    }
}
