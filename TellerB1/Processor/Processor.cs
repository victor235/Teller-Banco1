using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using Processor.ServiceReference;



namespace Processor
{
    public class ClsProcessor
    {

        Integrador_CoreSoapClient client = new Integrador_CoreSoapClient();

        public LocalCliente VerificarCliente(string cuenta)
        {
            LocalCliente cliente = new LocalCliente(cuenta);
            RequestDatosPersonales request = new RequestDatosPersonales();
            ResponseDatosPersonales datosPersonales = new ResponseDatosPersonales();

            request.datos = new Cliente();
            request.datos.codigo = cuenta;
            datosPersonales = client.Pedidosdatos(request);

            cliente.Codigo = datosPersonales.datos.codigo;
            cliente.Nombres = datosPersonales.datos.Nombres;
            cliente.Apellidos = datosPersonales.datos.Apellidos;
            return cliente;
        }

        public LocalCliente VerificarCedula(string cedula)
        {
            LocalCliente cliente = new LocalCliente();
            cliente.Cedula = cedula;
            RequestDatosPersonales request = new RequestDatosPersonales();
            ResponseDatosPersonales datosPersonales = new ResponseDatosPersonales();

            request.datos = new Cliente();
            request.datos.cedula = cedula;
            datosPersonales = client.Pedidosdatos(request);

            cliente.Codigo = datosPersonales.datos.codigo;
            cliente.Nombres = datosPersonales.datos.Nombres;
            cliente.Apellidos = datosPersonales.datos.Apellidos;
            return cliente;
        }

        public LocalConfirmacion RealizarDeposito(LocalDeposito Ldeposito)
        {
            //Instancias
            LocalConfirmacion localConfirmacion = new LocalConfirmacion();
            Confirmacion confirmacion = new Confirmacion();
            Deposito deposito = new Deposito();
            deposito.cuenta = new Cliente();
            //Cliente cliente = new Cliente();
            //cliente.Apellidos = Ldeposito.Cuenta.Apellidos;
            //cliente.Nombres = Ldeposito.Cuenta.Nombres;
            //cliente.codigo = Ldeposito.Cuenta.Codigo;
            
            
            //Casting deposito
            deposito.monto = Ldeposito.Monto;
            deposito.cuenta.Apellidos = Ldeposito.Cuenta.Apellidos;
            deposito.cuenta.Nombres = Ldeposito.Cuenta.Nombres;
            deposito.cuenta.codigo= Ldeposito.Cuenta.Codigo;
            deposito.fecha = Ldeposito.Fecha;

            //Ejecucion
            confirmacion = client.RealizarDeposito(deposito);

            //Casting confirmacion
            localConfirmacion.mensajeConfirmación = confirmacion.mensajeConfirmación;
            localConfirmacion.succeeded = confirmacion.success;
            return localConfirmacion;
        }

        public LocalConfirmacion RealizarRetiro(LocalRetiro Lretiro)
        {
            //Instancias
            LocalConfirmacion localConfirmacion = new LocalConfirmacion();
            Confirmacion confirmacion = new Confirmacion();
            Retiro retiro= new Retiro();
            retiro.cuenta = new Cliente();
            //Cliente cliente = new Cliente();
            //cliente.Apellidos = Ldeposito.Cuenta.Apellidos;
            //cliente.Nombres = Ldeposito.Cuenta.Nombres;
            //cliente.codigo = Ldeposito.Cuenta.Codigo;


            //Casting retiro
            retiro.monto = Lretiro.Monto;
            retiro.cuenta.Apellidos = Lretiro.Cuenta.Apellidos;
            retiro.cuenta.Nombres = Lretiro.Cuenta.Nombres;
            retiro.cuenta.codigo = Lretiro.Cuenta.Codigo;
            retiro.cuenta.cedula = Lretiro.Cuenta.Cedula;
            retiro.fecha = Lretiro.Fecha;

            //Ejecucion
            confirmacion = client.RealizarRetiro(retiro);

            //Casting confirmacion
            localConfirmacion.mensajeConfirmación = confirmacion.mensajeConfirmación;
            localConfirmacion.succeeded = confirmacion.success;
            return localConfirmacion;
        }

    }
}
