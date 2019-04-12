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
        Cajas caja;
        bool valido;
        bool activo;
        Sucursal sucursal;

        public Usuario()
        {
            this.Valido = false;
            this.sucursal = new Sucursal();
        }
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
        public Cajas Caja { get => caja; set => caja = value; }
        public Sucursal Sucursal { get => sucursal; set => sucursal = value; }

        public void GuardarContraseñaNueva(string nueva)
        {
            activo = true;
            contraseña = nueva;
            Caja_AppEntities6 caja_AppEntities = new Caja_AppEntities6();
            caja_AppEntities.tblUsuarios.Find(codigo_Usuario).Contraseña = contraseña;
            caja_AppEntities.tblUsuarios.Find(codigo_Usuario).Activo = true;
            caja_AppEntities.SaveChanges();
        }
      
    }

    public enum TipoUsuario { Cajero, Administrador};
}
