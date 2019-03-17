using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB;

namespace Processor
{
    public class ClsProcessor
    {
        public string Message { get; private set; }
        public bool VerifyPassword(int user, string password, string tipo)
        {
            DataManager manager = new DataManager();
            string[] datos;
            datos = manager.Password(user);

            
            if (password == datos[0] && tipo==datos[1])
            {
                Message = "Inicio de sesion exitoso!";
                return true;
            }
            else
            {
                Message = "Usuario o contraseña incorrectos";
                return false;
            } 
        }
    }
}
