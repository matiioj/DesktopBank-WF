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
        private readonly ValidationService _validationService;
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
            _validationService = new();
        }

        private async void BtnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            string apellido = TxtApellido.Text;
            string correo = TxtCorreo.Text;
            string cuil = TxtCuil.Text;
            string user = TxtUser.Text;
            string contra = TxtContra.Text;

            var mensajeError = _validationService.ValidateOnRegisterFields(nombre, apellido, correo, cuil, user, contra);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Los valores ingresados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // si confirma -> almacenamiento en BD y abre FormLogin
            if (resultado == DialogResult.Yes)
            {
                int currencyId = 1;
                try
                {
                    // Transaction, mas de una tabla involucrada 
                    await _coordinatorService.CreateClientUserAndAccountAsync(nombre, apellido, long.Parse(cuil), correo, user, contra, currencyId);
                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Ocurrió un error al guardar los datos internos: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
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



