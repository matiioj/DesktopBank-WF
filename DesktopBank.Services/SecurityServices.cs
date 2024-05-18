using DesktopBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public string ValidationMailService(string mensajeError, string nombre, string apellido, string correo, string cuil)
        {
            if (string.IsNullOrEmpty(mensajeError))
            {

                if (Regex.IsMatch(nombre, @"\d"))
                {
                    mensajeError += "El nombre no debe contener números.\n";
                    return mensajeError;
                }
                if (Regex.IsMatch(apellido, @"\d"))
                {
                    mensajeError += "El apellido no debe contener números.\n";
                    return mensajeError;
                }

                //formato de correo
                if (!Regex.IsMatch(correo, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    mensajeError += "El correo electrónico no tiene un formato válido.\n";
                    return mensajeError;
                }

                if (!Regex.IsMatch(cuil, @"^\d{11,11}$"))
                {
                    mensajeError += "El CUIL debe contener 11 dígitos numéricos.\n";
                    return mensajeError;
                }
                
            }
            return mensajeError;

        }



    }
}
