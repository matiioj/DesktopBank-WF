using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using DesktopBankUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem.WindowsFormsCliente
{
    public partial class FormRegister : Form
    {
        // MailService mailService = new MailService();
        private readonly CoordinatorService _coordinatorService;
        private readonly NojedaisticDesktopBankContext _context;
        private readonly ClientRepository _clientRepository;
        private readonly UserRepository _userRepository;
        private readonly AccountRepository _accountRepository;
        private readonly ClientService _clientService;
        private readonly UserService _userService;
        private readonly AccountService _accountService;
        private readonly UnitOfWork _unitOfWork;
        public FormRegister()
        {
            InitializeComponent();
            _context = new NojedaisticDesktopBankContext();
            _clientRepository = new ClientRepository(_context);
            _userRepository = new UserRepository(_context);
            _accountRepository = new AccountRepository(_context);
            _unitOfWork = new UnitOfWork(_context);
            _clientService = new ClientService(_clientRepository, _unitOfWork);
            _userService = new UserService(_userRepository, _unitOfWork);
            _accountService = new AccountService(_accountRepository, _unitOfWork);
            _coordinatorService = new CoordinatorService(_clientService, _userService, _accountService, _unitOfWork);
        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string correo = TxtCorreo.Text;
            string cuil = TxtCuil.Text;
            string user = TxtUser.Text;
            string contra = TxtContra.Text;

            string mensajeError = "";


            //se valida que ningun campo este vacio o nulo
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
                int currencyId = 1;
                try
                {
                    await _coordinatorService.CreateClientUserAndAccountAsync(nombre, apellido, long.Parse(cuil), correo, user, contra, currencyId);
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide(); // oculta FormRegister

                }
                catch (Exception ex)
                {
                    // Maneja la excepción aquí
                    MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar los datos internos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
            TxtContra.Text = "";
        }

        private void botonLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide(); // oculta FormRegister
        }
    }

}

/*
   //var Confirmacion = MessageBox.Show(Mensaje, "Confirmar",
   //    MessageBoxButtons.YesNo,MessageBoxIcon.Question);

   //if (Confirmacion == DialogResult.Yes)
   // {
        //Llama a la pantalla de las materias
   //     FrmCarreras frmCarreras = new FrmCarreras();
   //     frmCarreras.Show();
   // }
    //else
    //{
    //    MessageBox.Show("Revisa los datos, estan malos", "Error", 
    //        MessageBoxButtons.OK, MessageBoxIcon.Error);
   // }

}


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



