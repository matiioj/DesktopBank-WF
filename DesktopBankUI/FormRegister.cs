using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
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
using DesktopBank.BusinessObjects.Models;

namespace StudentSystem.WindowsFormsCliente
{
    public partial class FormRegister : Form
    {
        MailService mailService = new MailService();
        
        private readonly NojedaisticDesktopBankContext _context;
        private readonly IClientRepository _clientRepository;
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IUserRepository _userRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly ICardRepository _cardRepository;
        private readonly GenerateNumbersService _generateNumbersService;
        private readonly CreateClientService _clientService;
        private readonly CreateUserService _userService;
        private readonly CreateAccountService _accountService;
        private readonly CreateCardService _cardService;
        private readonly CreateBankUserEntitiesService _createBankUserEntitiesService;
        private readonly ValidationService _validationService;
        private readonly UnitOfWork _unitOfWork;
        public FormRegister()
        {
            _context = new NojedaisticDesktopBankContext();

            _clientRepository = new ClientRepository(_context);
            _currencyRepository = new CurrencyRepository(_context);
            _userRepository = new UserRepository(_context);
            _accountRepository = new AccountRepository(_context);
            _cardRepository = new CardRepository(_context);
            _unitOfWork = new UnitOfWork(_context);

            _generateNumbersService = new GenerateNumbersService();
            _clientService = new CreateClientService(_clientRepository, _unitOfWork);
            _userService = new CreateUserService(_userRepository, _unitOfWork);
            _accountService = new CreateAccountService(_accountRepository, _unitOfWork, _generateNumbersService);
            _cardService = new CreateCardService(_cardRepository, _unitOfWork, _generateNumbersService);
            _createBankUserEntitiesService = new CreateBankUserEntitiesService(_clientService, _userService, _accountService, _cardService, _unitOfWork);
            _validationService = new();

            InitializeComponent();
            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            var currencies = _currencyRepository.GetCurrencies().ToList();
            if (currencies != null && currencies.Any())
            {
                ComboBoxCurrencies.DataSource = currencies;
                ComboBoxCurrencies.DisplayMember = "CurrencyName";
                ComboBoxCurrencies.ValueMember = "CurrencyId";
            }
            else
            {
                MessageBox.Show("No se encontraron monedas en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                int currencyId = (int)ComboBoxCurrencies.SelectedValue; // obtener CurrencyId
                try
                {
                    // Transaction, mas de una tabla involucrada 
                    await _createBankUserEntitiesService.CreateBankUserEntitiesAsync(nombre, apellido, long.Parse(cuil), correo, user, contra, currencyId);
                    MailData mailData = new MailData();
                    mailData.MailTo = correo;
                    mailData.Subject = "Bienvenido a ISTIC DesktopBank";
                    mailData.Body = $"Bienvenido señor/a {nombre} como nuevo cliente";
                    mailService.SendMail(mailData);

                    FormLogin formLogin = new FormLogin();
                    formLogin.Show();
                    this.Hide();

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
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // limpiar cuadros texto
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
            this.Hide();
        }
    }

}





