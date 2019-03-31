using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    //Para añadir esta librería a sus çodigos, creen un proyecto de tipo class Library dentro de su solucion y 
    //despues hagan referencias de ella en las partes de su programa que vayan a usar.
    //Atención: Todos deben de generar sus propios constructores.
    //A Los constructores que están creados, solo se les puede agregar, si se va a modificar, favor avisar.
    //Los string son nulleable types, y el el decimal tambien, por lo que si en sus códigos no tienen
    //algun dato de un cliente(como la cuenta a la que se le va a transferir dinero), es bueno darle un valor null.
    //Usar el reloj del sistema para rellenar los datetime de las transacciones.

    public class LocalCliente
    {
        string codigo;
        string nombres;
        string apellidos;
        decimal balance;
        string cedula;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public LocalCliente(string cuenta)
        {
            this.codigo = cuenta;
        }

        public LocalCliente() { }
    }

    public enum LocalTipoPedido { transferencia, retiro, deposito, datosPersonales }
    public enum LocalTipoRespuesta { confimacion, DatosPersonales }

    public class LocalPedido
    {
        public LocalTipoPedido tipo { get; internal set; }
    }

    public class LocalRespuesta
    {
        public LocalTipoRespuesta tipo { get; internal set; }
    }

    #region Pedidos

    public class LocalTransferencia : LocalPedido
    {
        LocalTransferencia()
        {
            tipo = (LocalTipoPedido)0;
        }
        LocalCliente cuentaOrigen;
        LocalCliente cuentaDestino;
        decimal monto;
        DateTime fecha;

        public LocalCliente CuentaOrigen { get => cuentaOrigen; set => cuentaOrigen = value; }
        public LocalCliente CuentaDestino { get => cuentaDestino; set => cuentaDestino = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }

    public class LocalRetiro : LocalPedido
    {
        LocalRetiro()
        {
            tipo = (LocalTipoPedido)1;
        }
        LocalCliente cuenta;
        decimal monto;
        DateTime fecha;

        public LocalCliente Cuenta { get => cuenta; set => cuenta = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }

    public class LocalDeposito : LocalPedido
    {
        LocalDeposito()
        {
            tipo = (LocalTipoPedido)2;
        }
        LocalCliente cuenta;
        decimal monto;
        DateTime fecha;

        public LocalCliente Cuenta { get => cuenta; set => cuenta = value; }
        public decimal Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
    public class LocalRequestDatosPersonales : LocalPedido
    {
        LocalRequestDatosPersonales()
        {
            tipo = (LocalTipoPedido)3;
        }
        public LocalCliente datos; //Aqui me dan un cliente con algun campo incompleto(null) y yo les devuelvo el cliente completo (es como un find).
    }
    #endregion

    #region LocalRespuestas

    public class LocalConfirmacion : LocalRespuesta
    {
        LocalConfirmacion()
        {
            tipo = (LocalTipoRespuesta)0;
        }
        public string mensajeConfirmación { get; internal set; }
    }

    public class LocalResponseDatosPersonales : LocalRespuesta
    {
        LocalResponseDatosPersonales()
        {
            tipo = (LocalTipoRespuesta)1;
        }
        public LocalCliente datos=new LocalCliente(); //Aqui me dan un cliente con algun campo incompleto(null) y yo les devuelvo el cliente completo (es como un find).
    }
    #endregion


}
