using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB;
using Mensajes;
using Processor.Integrador;
using System.Web.Services.Protocols;



namespace Processor
{
    public class ClsProcessor
    {
        string message;
        public string Message { get => message; private set { } }

        Integrador_CoreSoapClient client = new Integrador_CoreSoapClient();
        
       

        public LocalCliente VerificarCliente(string cuenta)
        {
            
            LocalCliente cliente = new LocalCliente(cuenta);
            RequestDatosPersonales request = new RequestDatosPersonales();
            ResponseDatosPersonales datosPersonales = new ResponseDatosPersonales();

            request.datos = new Cliente();
            request.datos.codigo = cuenta;
            client.Open();
            datosPersonales = client.Pedidosdatos(request);

            cliente.Codigo = datosPersonales.datos.codigo;
            cliente.Nombres = datosPersonales.datos.Nombres;
            cliente.Apellidos = datosPersonales.datos.Apellidos;
            return cliente;
        }

        public LocalConfirmacion RealizarDeposito(LocalDeposito deposito)
        {
            

            return new LocalConfirmacion();
        }
       
        
    }
}
