using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB;

namespace Processor
{
    public class Usuario
    {
        int codigo_Usuario;
        string apellidos;
        string nombres;
        string contraseña;
        TipoUsuario tipo;
        bool valido;


        public Usuario(int codigo_Usuario, string contraseña, TipoUsuario tipo)
        {
            this.codigo_Usuario = codigo_Usuario;
            this.contraseña = contraseña;
            this.tipo = tipo;
            this.Valido = false;
        }
        //public Usuario(string nombre, string apellido, int codigo_Usuario, string contraseña, TipoUsuario tipo)
        //{
        //    this.nombres = nombre;
        //    this.apellidos = apellido;
        //    this.contraseña = contraseña;
        //    this.codigo_Usuario = codigo_Usuario;
        //    this.tipo = TipoUsuario.Cajero;

        //}

        public int Codigo_Usuario { get => codigo_Usuario; private set { } }
        public string Apellidos { get => apellidos; private set { } }
        public string Nombres { get => nombres; private set { } }
        public TipoUsuario Tipo { get => tipo; private set { } }
        public bool Valido { get => valido; private set { } }

        public string ValidarUsuario()
        {
            string message;
            int idTipo;
            DataManager manager = new DataManager();
            string[] datos;
            datos = manager.DatosUsuario(codigo_Usuario);

            if (tipo == TipoUsuario.Administrador)
            {
                idTipo = 2;
            }
            else
            {
                idTipo = 1;
            }

            if (contraseña == datos[3] && idTipo.ToString() == datos[4])
            {
                apellidos = datos[1];
                nombres = datos[2];
                message = "Inicio de sesion exitoso!";
                valido = true;
            }
            else
            {
                message = "Usuario o contraseña incorrectos";
                valido = false;
            }
            return message;
        }
    }

    public enum TipoUsuario { Cajero, Administrador};
}
