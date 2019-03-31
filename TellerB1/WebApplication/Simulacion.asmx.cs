using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication
{
    /// <summary>
    /// Summary description for Simulacion
    /// </summary>
    [WebService(Namespace = "http://Simulador.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Simulacion : System.Web.Services.WebService
    {

        [WebMethod]
        public Cliente CompletarCliente(Cliente cliente)
        {
            if (cliente.Codigo.Length < 5)
                return cliente;
            else
            {
                cliente.Nombres = "Fulanito";
                cliente.Apellidos = "De Tal";
                return cliente;
            }
        }
    }
}
