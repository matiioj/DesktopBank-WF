using Azure.Identity;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using Microsoft.IdentityModel.Tokens;
using StudentSystem.WindowsFormsCliente;
using System.Windows.Forms.Design;
using System.Windows.Media.Media3D;

namespace DesktopBankUI
{
    public partial class FormLogin : Form
    {
        private readonly NojedaisticDesktopBankContext _context;
        private readonly UserCheckerService _sessionService;
        private readonly UserRepository _userRepository;
        private readonly PasswordHashingService _passwordHashingService;
        private bool showPassword;
        private readonly CreateReceiptService _createReceiptService;
        public FormLogin()
        {
            _createReceiptService = new CreateReceiptService();
            _context = new NojedaisticDesktopBankContext();
            _userRepository = new UserRepository(_context);
            _passwordHashingService = new PasswordHashingService();
            _sessionService = new UserCheckerService(_userRepository, _passwordHashingService);
            InitializeComponent();
            _createReceiptService.CreateReceipt();
        }
        private void registerLabel_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new();
            frmRegister.Show();
            this.Hide();
        }

        private void opcionSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuarioLogin = TxtUser.Text;
            var contraLogin = TxtPassword.Text;


            var message = _sessionService.CredentialsChecker(usuarioLogin, contraLogin);
            if (int.TryParse(message, out int id))
            {
                FormMain formMain = new FormMain(id);
                formMain.Show();
                this.Hide(); // oculta FormLogin
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tituloIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void linkChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangePass frmChangePass = new FormChangePass();
            frmChangePass.Show();
            this.Hide();
        }

        private void pbShowHide_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                TxtPassword.PasswordChar = '\0';
                pbShowHide.Image = DesktopBankUI.Properties.Resources.hideBlue;
            }
            else {
                TxtPassword.PasswordChar = '*';
                pbShowHide.Image = DesktopBankUI.Properties.Resources.showBlue;
            }
        }
    }
}
