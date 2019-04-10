using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataModel
{
    public class Usuario
    {
        int codigo_Usuario;
        string apellidos;
        string nombres;
        string contraseña;
        TipoUsuario tipo;
        bool valido;
        bool activo;

        public Usuario() { this.Valido = false; }
        public Usuario(int codigo_Usuario, string contraseña, TipoUsuario tipo)
        {
            this.Codigo_Usuario = codigo_Usuario;
            this.Contraseña = contraseña;
            this.Tipo = tipo;
            this.Valido = false;
        }
        public Usuario(string nombre, string apellido, int codigo_Usuario, string contraseña, TipoUsuario tipo)
        {
            this.Nombres = nombre;
            this.Apellidos = apellido;
            this.Contraseña = contraseña;
            this.Codigo_Usuario = codigo_Usuario;
            this.Tipo = TipoUsuario.Cajero;
            this.Valido = false;
        }

        public int Codigo_Usuario { get => codigo_Usuario; set => codigo_Usuario = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public TipoUsuario Tipo { get => tipo; set => tipo = value; }
        public bool Valido { get => valido; set => valido = value; }
        public bool Activo { get => activo; set => activo = value; }

        public void GuardarContraseñaNueva(string nueva)
        {
            activo = true;
            contraseña = nueva;
            Caja_AppEntities caja_AppEntities = new Caja_AppEntities();
            caja_AppEntities.tblUsuarios.Find(codigo_Usuario).Contraseña = contraseña;
            caja_AppEntities.SaveChanges();
        }
        //public string ValidarUsuario()
        //{
        //    //Declaraciones e instancias
        //    string message;
        //    int idTipo;
        //    DataManager manager = new DataManager();
        //    string[] datos;

        //    //Asignaciones y procesos
        //    //datos = manager.DatosUsuario(Codigo_Usuario);

        //    if (Tipo == TipoUsuario.Administrador)
        //    {
        //        idTipo = 2;
        //    }
        //    else
        //    {
        //        idTipo = 1;
        //    }

        //    if (Contraseña == datos[3] && idTipo.ToString() == datos[4])
        //    {
        //        Apellidos = datos[1];
        //        Nombres = datos[2];
        //        message = "Inicio de sesion exitoso!";
        //        Valido = true;
        //    }
        //    else
        //    {
        //        message = "Usuario o contraseña incorrectos";
        //        Valido = false;
        //    }
        //    return message;
        //}
    }

    public enum TipoUsuario { Cajero, Administrador};
}
