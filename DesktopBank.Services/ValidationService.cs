using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class ValidationService
    {
        public ValidationService() 
        {
        }

        public string ValidateOnRegisterFields(string nombre, string apellido, string correo, string cuil, string user, string contra) 
        {
            string mensajeError = "";

            if (string.IsNullOrEmpty(nombre))
            {
                mensajeError += "El campo de nombre no puede estar vacío.\n";
            }
            if (string.IsNullOrEmpty(apellido))
            {
                mensajeError += "El campo de apellido no puede estar vacío.\n";
            }
            if (string.IsNullOrEmpty(correo))
            {
                mensajeError += "El campo de correo electrónico no puede estar vacío.\n";
            }
            if (string.IsNullOrEmpty(cuil))
            {
                mensajeError += "El campo de CUIL no puede estar vacío.\n";
            }
            if (string.IsNullOrEmpty(user))
            {
                mensajeError += "El campo de usuario no puede estar vacío.\n";
            }
            if (string.IsNullOrEmpty(contra))
            {
                mensajeError += "El campo de contraseña no puede estar vacío.\n";
            }

            /*
            Validaciones con Regex:
            Regex.IsMatch(): método de la clase Regex en C#
            que se utiliza para determinar si una cadena de texto
            coincide con un patrón especificado por una expresión regular.
            La expresión regular se proporciona como el primer argumento del 
            método, y la cadena que se desea verificar se proporciona como el 
            segundo. El método devuelve true si la cadena cumple con el patrón 
            especificado por la expresión regular, y false en caso contrario.
            */

            //si ninguna de las variables estaba vacia o nula, se sigue
            //con las siguientes validaciones
            if (string.IsNullOrEmpty(mensajeError))
            {

                if (Regex.IsMatch(nombre, @"\d"))
                {
                    mensajeError += "El nombre no debe contener números.\n";
                }
                if (Regex.IsMatch(apellido, @"\d"))
                {
                    mensajeError += "El apellido no debe contener números.\n";
                }

                //formato de correo
                if (!Regex.IsMatch(correo, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                {
                    mensajeError += "El correo electrónico no tiene un formato válido.\n";
                }

                if (!Regex.IsMatch(cuil, @"^\d{11,11}$"))
                {
                    mensajeError += "El CUIL debe contener 11 dígitos numéricos.\n";
                }
            }

            return mensajeError;

        }
        
    }
}
