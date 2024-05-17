using DesktopBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBank.Services
{
    internal class SecurityServices
    {
        public string UserRegisterEmptyService(string mensajeError, string nombre, string apellido, string correo, string cuil, string user)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                mensajeError += "El campo de nombre no puede estar vacío.\n";
                return mensajeError;
            }
            if (string.IsNullOrEmpty(apellido))
            {
                mensajeError += "El campo de apellido no puede estar vacío.\n";
                return mensajeError;
            }
            if (string.IsNullOrEmpty(correo))
            {
                mensajeError += "El campo de correo electrónico no puede estar vacío.\n";
                return mensajeError;
            }
            if (string.IsNullOrEmpty(cuil))
            {
                mensajeError += "El campo de CUIL no puede estar vacío.\n";
                return mensajeError;
            }
            if (string.IsNullOrEmpty(user))
            {
                mensajeError += "El campo de usuario no puede estar vacío.\n";
                return mensajeError;
            }
            return mensajeError;

        }
    
    }
}
