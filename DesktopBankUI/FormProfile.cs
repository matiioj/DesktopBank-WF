using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
//using Microsoft.Identity.Client.NativeInterop;

//using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBankUI
{
    public partial class FormProfile : Form
    {
        string cbu;
        string alias;
        long CUIL;
        string mail;
        MailService mailService = new MailService();
        NojedaisticDesktopBankContext _context;
        AccountRepository _accountRepository;
        Account _account;
        ValidationService _validationService;
        PasswordHashingService _passwordHashingService;
        public FormProfile(Account currentAccount, NojedaisticDesktopBankContext context)
        {

            cbu = currentAccount.AccountCbu.ToString();
            alias = currentAccount.AccountAlias;
            CUIL = currentAccount.User.Client.ClientCuil;
            mail = currentAccount.User.Client.ClientEmail;
            _account = currentAccount;
            _context = context;
            _accountRepository = new AccountRepository(_context);
            _validationService = new();
            _passwordHashingService = new PasswordHashingService();

            InitializeComponent();
            CargarDatos_Usuario();
        }


        public void CargarDatos_Usuario()
        {
            LabelContenidoAlias.Text = alias;
            LabelContenidoCbu.Text = cbu;
            LabelContenidoCuil.Text = Convert.ToString(CUIL);
        }

        private void LabelContenidoCbu_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LabelContenidoCbu.Text);
            MessageBox.Show("Su número ha sido copiado con éxito");
        }

        private void LabelPerfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyAlias_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LabelContenidoAlias.Text);
            MessageBox.Show("Su Alias ha sido copiado con éxito");
        }

        private void btnCambiarAlias_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = true;
        }

        private void panelCambiarAlias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarAlias_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = false;
        }

        private void btnAceptarAlias_Click(object sender, EventArgs e)
        {
            string aliasNuevo = txtCambiarAlias.Text;
            _account.AccountAlias = aliasNuevo;
            _accountRepository.Update(_account);
            _context.SaveChanges();
        }

        private void btnAceptarMail_Click(object sender, EventArgs e)
        {
            string correoNuevo = txtCambiarMail.Text;

            var mensajeError = _validationService.ValidateOnRegisterFields(correoNuevo);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Quiere cambiar su antiguo mail: {mail} por {correoNuevo}?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    _account.AccountAlias = correoNuevo;
                    _accountRepository.Update(_account);
                    _context.SaveChanges();
                    MessageBox.Show("Su correo se ha actualizado con éxito");
                    MailData mailData = new MailData();
                    mailData.MailTo = correoNuevo;
                    mailData.Subject = "Cambio de correo ISTIC DesktopBank";
                    mailData.Body = $"Se ha validado su nuevo correo electrónico";
                    mailService.SendMail(mailData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnChangeMail_Click(object sender, EventArgs e)
        {
            panelAceptarMail.Visible = true;
        }

        private void btnCancelarContra_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = false;
        }

        private void btnCancelarMail_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = false;
        }

        private void btnAceptarContra_Click(object sender, EventArgs e)
        {

        }
    }
}
