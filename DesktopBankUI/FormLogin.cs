using Azure.Identity;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using Microsoft.IdentityModel.Tokens;
using StudentSystem.WindowsFormsCliente;
using System.Windows.Forms.Design;

namespace DesktopBankUI
{
    public partial class FormLogin : Form
    {
        private readonly NojedaisticDesktopBankContext _context;
        private readonly SessionService _sessionService;
        private readonly UserRepository _userRepository;
        public FormLogin()
        {
            _context = new NojedaisticDesktopBankContext();
            _userRepository = new UserRepository(_context);
            _sessionService = new SessionService(_userRepository);
            InitializeComponent();   
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

            if (message.IsNullOrEmpty())
            {
                FormMain formMain = new FormMain(_sessionService);
                formMain.Show();
                this.Hide(); // oculta FormLogin
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
