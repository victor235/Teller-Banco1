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
        public ResponseDatosPersonales CompletarCliente(RequestDatosPersonales request)
        {
            ResponseDatosPersonales datosPersonales = new ResponseDatosPersonales();
            datosPersonales.datos = request.datos;
            if (request.datos.Codigo.Length < 5)
                return datosPersonales;
            else
            {
                datosPersonales.datos.Nombres = "Fulanito";
                datosPersonales.datos.Apellidos = "De Tal";
                return datosPersonales;
            }
        }

        [WebMethod]
        public Confirmacion RealizarDeposito(Deposito deposito)
        {
            if (deposito.Monto > 5000)
            {

            }
                
            return new Confirmacion();
        }
    }
}
