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
        private Caja_AppEntities6 caja_AppEntities = new Caja_AppEntities6();
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
            usuario.Sucursal.Id = tblusuarios.tblSucursales.Id;
            usuario.Sucursal.Ubicacion = tblusuarios.tblSucursales.Ubicacion;
            usuario.Sucursal.Provincia = tblusuarios.tblSucursales.Provincia;
            //Caja
            if (tblusuarios.Caja != null)
            {
                usuario.Caja = new Cajas();
                usuario.Caja.Balance = tblusuarios.tblCajas.Balance;
                usuario.Caja.Descripcion = tblusuarios.tblCajas.Descripcion;
                usuario.Caja.Estado = (EstadoCaja)(tblusuarios.tblCajas.Estado - 1);
                usuario.Caja.Id = tblusuarios.tblCajas.Id;
                usuario.Caja.Sucursal = new Sucursal();
                usuario.Caja.Sucursal.Id = tblusuarios.tblCajas.tblSucursales.Id;
                usuario.Caja.Sucursal.Provincia = tblusuarios.tblCajas.tblSucursales.Provincia;
                usuario.Caja.Sucursal.Ubicacion = tblusuarios.tblCajas.tblSucursales.Ubicacion;
            }
           
            return usuario;
        }

        public void SaveChanges(Caja_AppEntities6 teller)
        {
            teller.SaveChanges();
        }

        public LocalConfirmacion AgregarCajero()
        {

            return new LocalConfirmacion(true);
        }

        #region Datatables
        public DataTable DenominacionesDataTable()
        {
            DataTable Data = new DataTable();
            DataColumn column;
            

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Denominacion";
            column.ColumnName = "Denominacion";
            column.DataType = typeof(int);
            column.DefaultValue = 0;
            column.ReadOnly = true;
            column.Unique = true;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Cantidad";
            column.ColumnName = "Cantidad";
            column.DataType = typeof(int);
            column.DefaultValue = 0;
            column.ReadOnly = false;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Monto";
            column.ColumnName = "Monto";
            column.DataType = typeof(int);
            column.DefaultValue = 0;
            column.ReadOnly = false;
            column.Unique = false;
            Data.Columns.Add(column);

            
            return Data;
        }
        public DataTable LLenarFilas()
        {
            DataTable Data = DenominacionesDataTable();
            DataRow row;

            row = Data.NewRow();
            row["Denominacion"] = 1;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 5;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 10;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 20;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 25;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 50;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 100;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 200;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 500;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 1000;
            Data.Rows.Add(row);

            row = Data.NewRow();
            row["Denominacion"] = 2000;
            Data.Rows.Add(row);

            return Data;
        }
        public DataTable InventarioDataTable(int caja)
        {
            DataTable Data = DenominacionesDataTable();

            DataColumn column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Tipo";
            column.ColumnName = "Tipo";
            column.DataType = typeof(string);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            Caja_AppEntities6 teller = new Caja_AppEntities6();
            var result = teller.GetInventario(caja);
            foreach (var item in teller.GetInventario(caja))
            {
                DataRow row = Data.NewRow();
                row["Denominacion"] = item.Valor;
                row["Cantidad"] = item.Cantidad;
                row["Monto"] = item.Valor * item.Cantidad;
                row["Tipo"] = item.Descripcion;
                Data.Rows.Add(row);
            }

            return Data;
        }
        #endregion

        public DataTable Transacciones(Usuario cajero, DateTime desde, DateTime hasta)
        {
            DataTable Data = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "No. Transaccion";
            column.ColumnName = "No. Transaccion";
            column.DataType = typeof(int);
            column.ReadOnly = true;
            column.Unique = true;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Tipo";
            column.ColumnName = "Tipo";
            column.DataType = typeof(string);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Monto";
            column.ColumnName = "Monto";
            column.DataType = typeof(decimal);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Cuenta";
            column.ColumnName = "Cuenta";
            column.DataType = typeof(string);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Caja";
            column.ColumnName = "Caja";
            column.DataType = typeof(string);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Banco";
            column.ColumnName = "Banco";
            column.DataType = typeof(string);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            column = new DataColumn();
            column.AutoIncrement = false;
            column.Caption = "Fecha";
            column.ColumnName = "Fecha";
            column.DataType = typeof(DateTime);
            column.ReadOnly = true;
            column.Unique = false;
            Data.Columns.Add(column);

            foreach (var trans in caja_AppEntities.tblTransaccion)
            {
                if (trans.Cajero == cajero.Codigo_Usuario)
                {
                    if(trans.Fecha>=desde && trans.Fecha <= hasta)
                    {
                        row = Data.NewRow();
                        row["No. Transaccion"] = trans.Id;
                        row["Tipo"] = trans.tblTipo_Transaccion.Descripcion;
                        row["Monto"] = trans.Monto;
                        row["Cuenta"] = trans.Cuenta;
                        row["Caja"] = trans.Caja;
                        row["Banco"] = trans.Banco;
                        row["Fecha"] = trans.Fecha;
                        Data.Rows.Add(row);
                    }
                }
            }

            return Data;

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
