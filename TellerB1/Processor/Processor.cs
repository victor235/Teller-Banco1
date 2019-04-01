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
        public string Message { get => message; private set { } }

        SimulacionSoapClient client = new SimulacionSoapClient();

        public LocalCliente VerificarCliente(string cuenta)
        {
            LocalCliente cliente = new LocalCliente(cuenta);
            RequestDatosPersonales request = new RequestDatosPersonales();
            ResponseDatosPersonales datosPersonales = new ResponseDatosPersonales();

            request.datos = new Cliente();
            request.datos.Codigo = cuenta;
            datosPersonales = client.CompletarCliente(request);

            cliente.Codigo = datosPersonales.datos.Codigo;
            cliente.Nombres = datosPersonales.datos.Nombres;
            cliente.Apellidos = datosPersonales.datos.Apellidos;
            return cliente;
        }

       
        
    }
}
