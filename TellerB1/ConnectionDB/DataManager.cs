using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.Entity.SqlServer;


namespace DataModel
{
    public class DataManager
    {
        private Caja_AppEntities caja_AppEntities = new Caja_AppEntities();
        private ConnectionDB Connection = new ConnectionDB();
        //private SqlCommand Command = new SqlCommand();
        //private SqlDataReader Reader;

        public Usuario DatosUsuario(int id)
        {
            
            //Declaraciones e Instancias
            Usuario usuario = new Usuario();
            //string[] datos = new string[5];

            tblUsuarios tblusuarios = caja_AppEntities.tblUsuarios.Find(id);
            if (tblusuarios == null)
                throw new Exception("Usuario o contraseña incorrectos");

            usuario.Apellidos = tblusuarios.Apellidos;
            usuario.Nombres = tblusuarios.Nombres;
            usuario.Contraseña = tblusuarios.Contraseña;
            usuario.Tipo = (TipoUsuario)(tblusuarios.Tipo-1);
            usuario.Codigo_Usuario = tblusuarios.Codigo_Usuario;
            usuario.Activo = tblusuarios.Activo;
            
            
            ////Consulta en Base de Datos
            //Command.Connection = Connection.OpenConnection();
            //Command.CommandText = "tblUsuarios_GetById";
            //Command.CommandType = CommandType.StoredProcedure;
            //Command.Parameters.AddWithValue("@Codigo_Usuario", id);
            //Reader = Command.ExecuteReader();
            //while (Reader.Read())
            //{
            //    datos[0] = Reader[0].ToString();
            //    datos[1] = Reader[1].ToString();
            //    datos[2] = Reader[2].ToString();
            //    datos[3] = Reader[3].ToString();
            //    datos[4] = Reader[4].ToString();
            //}
            //Command.Parameters.Clear();
            //Command.Connection = Connection.CloseConnection();

            return usuario;
        }

        public LocalConfirmacion AgregarCajero()
        {

            return new LocalConfirmacion(true);
        }
    }

    internal static class MissingDllHack
    {
        // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
        // included in the output folder of referencing projects without requiring a direct 
        // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
        private static SqlProviderServices instance = SqlProviderServices.Instance;
    }
}
