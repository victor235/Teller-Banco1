using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB;
using Mensajes;


namespace Processor
{
    public class ClsProcessor
    {
        string message;
        public string Message { get => message; private set { } }

        ServiceReference.SimulacionSoapClient simulacionSoapClient = new ServiceReference.SimulacionSoapClient();

        public Cliente VerificarCliente(string cuenta)
        {
            Cliente cliente = new Cliente(cuenta);
            ServiceReference.Cliente webCliente = new ServiceReference.Cliente();
            webCliente.Codigo = cliente.Codigo;
            webCliente = simulacionSoapClient.CompletarCliente(webCliente);
            cliente.Codigo = webCliente.Codigo;
            cliente.Nombres = webCliente.Nombres;
            cliente.Apellidos = webCliente.Apellidos;
            return cliente;
        }
        
    }
}
