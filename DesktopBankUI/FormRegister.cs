using DesktopBankUI;
using System.Text.RegularExpressions;
//using DesktopBank.Services;


namespace StudentSystem.WindowsFormsCliente
{
    public partial class FormRegister : Form
    {
        // MailService mailService = new MailService();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            

            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string correo = TxtCorreo.Text;
            string cuil = TxtCuil.Text;
            string user = TxtUser.Text;
            string mensajeError = "";       

            mensajeError+=ValidationEmptyService(mensajeError, nombre, apellido, correo, cuil, user);
            mensajeError+=ValidationMailService(mensajeError, nombre, apellido, correo,cuil);
     
            //mensaje de error
            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //confirmacion
            DialogResult resultado = MessageBox.Show("¿Los valores ingresados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // si confirma -> FormLogin | almacenación en BDD
            if (resultado == DialogResult.Yes)
            {
                //almacenar en BDD aca?
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide(); // oculta FormRegister
            }

            //se valida que ningun campo este vacio o nulo
            //Hay que pasar éstas funciones a la capa servicio, previa referencia de capa UI con la capa DesktopBank.Service.
            string ValidationEmptyService(string mensajeError, string nombre, string apellido, string correo, string cuil, string user)
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

            string ValidationMailService(string mensajeError, string nombre, string apellido, string correo, string cuil)
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

        //botón para limpiar cuadros
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los cuadros de texto
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtCorreo.Text = "";
            TxtCuil.Text = "";
            TxtUser.Text = "";
            //TxtContra.Text = ""; No es necesaria la contraseña en el registro
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide(); // oculta FormRegister
        }

        private void TxtCuil_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //Llama a la pantalla de las materias
    

}




   //     FrmCarreras frmCarreras = new FrmCarreras();
   //     frmCarreras.Show();
   // }
    //else
    //{
    //    MessageBox.Show("Revisa los datos, estan malos", "Error", 
    //        MessageBoxButtons.OK, MessageBoxIcon.Error);
   // }




    //Validaciones
    /*
     var newUsuario = new();


    // AgregarUsuario(newUsuario);

    MailData mailData = new MailData();

    mailData.MailTo = TxtCorreo.Text;
    mailData.Subject = "Registro en StudentSystem";
    mailData.Body = $"Hola aqui va tu clave temporal: {newUsuario.Clave}";

    mailService.SendMail(mailData);


    //this.Close();
*/



