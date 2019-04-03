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
        string message;
        bool OnLIne;

        public string Message { get => message; private set { } }

         Integrador_CoreSoapClient client= new Integrador_CoreSoapClient();

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

        //public LocalConfirmacion RealizarDeposito(LocalDeposito Ldeposito)
        //{
        //    Confirmacion confirmacion = new Confirmacion();
        //    Deposito deposito = new Deposito();
        //    deposito.Monto = Ldeposito.Monto;
        //    deposito.Cuenta = Ldeposito.Cuenta;
        //    deposito.Fecha = Ldeposito.Fecha;
        //    confirmacion = Metodo(deposito);
        //    return confirmacion();
        //}

       
        
    }
}
