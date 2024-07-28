using DesktopBank.BusinessObjects.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using DesktopBank.BusinessObjects.Generated.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBankUI
{
    public partial class FormChangePass : Form
    {
        private readonly ValidationService _validationService;
        private readonly MailService mailService = new MailService();
        private readonly NojedaisticDesktopBankContext _context;
        private readonly AccountRepository _accountRepository;
        private readonly Account _account;
        private readonly PasswordHashingService _passwordHashingService;

        public FormChangePass(NojedaisticDesktopBankContext context)
        {
            _context = context;
            _accountRepository = new AccountRepository(_context);
            _passwordHashingService = new PasswordHashingService();
            _validationService = new();
            InitializeComponent();
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarChP_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void txtMailChangePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarCode_Click(object sender, EventArgs e)
        {
            string validarMail = txtMailChangePass.Text;
            
            Account _account = null;

            string mailConfirmado;

            string code;

            var mensajeError = _validationService.ValidateOnRegisterFields(validarMail);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _account = _accountRepository.GetByEmail(validarMail);
            if(_account != null)
            {
                DialogResult resultado = MessageBox.Show($"¿Enviar código de reestablecimiento de contraseña al correo: {_account.User.Client.ClientEmail}?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        code = new Random().Next().ToString();

                        //_account.User.Client.ClientEmail = correoNuevo;
                        //_accountRepository.Update(_account);
                        //_context.SaveChanges();
                        //MessageBox.Show("Su correo se ha actualizado con éxito");
                        MailData mailData = new MailData();
                        mailData.MailTo = validarMail;
                        mailData.Subject = "Código de restablecimiento de contraseña";
                        mailData.Body = $"Su código de restablecimiento de la contraseña es: {code}";
                        mailService.SendMail(mailData);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al enviar el código de restablecimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                mensajeError = "El correo no corresponde a un usuario registrado";
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            


        }
    }
}
