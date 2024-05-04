using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem.WindowsFormsCliente
{
    public partial class FormRegister : Form
    {
        MailService mailService = new MailService();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Validaciones

            var newUsuario = new();
            newUsuario.Nombre = TxtNombre.Text;
            newUsuario.Apellido = TxtApellido.Text;
            newUsuario.Correo = TxtCorreo.Text;
            newUsuario.UserName = TxtUser.Text;
            newUsuario.Clave = new Random().Next().ToString();

            // AgregarUsuario(newUsuario);

            MailData mailData = new MailData();

            mailData.MailTo = TxtCorreo.Text;
            mailData.Subject = "Registro en StudentSystem";
            mailData.Body = $"Hola aqui va tu clave temporal: {newUsuario.Clave}";

            mailService.SendMail(mailData);


            //this.Close();

        }
    }
}
