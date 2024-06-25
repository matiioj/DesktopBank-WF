using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DesktopBank.Services;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesktopBankUI
{
    public partial class FormMain : Form
    {
        private int borderSize = 1;
        private readonly AccountInfoService _accountInfoService;
        private readonly AccountRepository _accountRepository;
        private readonly NojedaisticDesktopBankContext _context;
        private readonly Account _currentAccount;
        private readonly DepositBalanceService _depositBalanceService;
        private readonly ExtractBalanceService _extractBalanceService;
        private readonly CreateOperationService _createOperationService;
        private readonly UnitOfWork _unitOfWork;
        private readonly GenerateNumbersService _generateNumbersService;
        private readonly ManageOperationsService _manageOperationsService;
        private readonly CheckAccountTransfer _checkAccountTransfer;
        private readonly CreateTransferService _createTransferService;
        private readonly OperationRepository _operationRepository;
        private readonly IOperationCodeRepository _operationCodeRepository;

        // Se utiliza una API de Windows para poder generar una ventana arrastrable 
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormMain(int userId)
        {
            _context = new NojedaisticDesktopBankContext();
            _unitOfWork = new UnitOfWork(_context);
            _accountRepository = new AccountRepository(_context);
            _operationRepository = new OperationRepository(_context);
            _operationCodeRepository = new OperationCodeRepository(_context);

            _generateNumbersService = new();
            _manageOperationsService = new ManageOperationsService(_operationRepository, _unitOfWork);
            _createOperationService = new CreateOperationService(_operationRepository, _unitOfWork, _generateNumbersService);
            _extractBalanceService = new ExtractBalanceService(_accountRepository, _createOperationService, _unitOfWork);
            _depositBalanceService = new DepositBalanceService(_accountRepository, _createOperationService, _unitOfWork);
            _accountInfoService = new AccountInfoService(_context, _accountRepository);
            _checkAccountTransfer = new CheckAccountTransfer(_accountRepository);
            _createTransferService = new CreateTransferService(_operationCodeRepository, _accountRepository, _createOperationService, _unitOfWork);

            _currentAccount = _accountInfoService.GetAccountByUserId(userId);

            InitializeComponent();
            FormHome formHome = new(_currentAccount, _context, _depositBalanceService, _accountInfoService, _extractBalanceService, _operationRepository);
            openFormInsidePanel(formHome);
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.Teal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restoreButton.Visible = true;
            maximizeButton.Visible = false;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restoreButton.Visible = false;
            maximizeButton.Visible = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        public void openFormInsidePanel(Form functionForm)
        {
            // Verifica si hay algún control dentro del panelScreen
            if (this.panelScreen.Controls.Count > 0)
            {
                // Si hay algún control, lo elimina (en este caso, el primer control)
                this.panelScreen.Controls.RemoveAt(0);
            }
            // Configura la ventana que se va a mostrar
            functionForm.TopLevel = false; // Indica que no es una ventana superior (no tiene marco)
            functionForm.Dock = DockStyle.Fill; // Rellena todo el espacio del panelScreen
            this.panelScreen.Controls.Add(functionForm); // Agrega la ventana al panelScreen
            this.panelScreen.Tag = functionForm; // Asigna la ventana como etiqueta del panelScreen
            functionForm.Show(); // Muestra la ventana
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            FormHome formHome = new(_currentAccount, _context, _depositBalanceService, _accountInfoService, _extractBalanceService, _operationRepository);
            openFormInsidePanel(formHome); //abrir en misma ventana
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new(_currentAccount, _context);
            openFormInsidePanel(profileForm);
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            FormCard cardForm = new(_currentAccount);
            openFormInsidePanel(cardForm);
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            FormTransferencia transferForm = new(_currentAccount, _checkAccountTransfer, _createTransferService);
            openFormInsidePanel(transferForm);
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            FormTransactions transactionsForm = new(_currentAccount, _context, _operationRepository, _accountInfoService, _manageOperationsService);
            openFormInsidePanel(transactionsForm);
        }

        private void btnPayService_Click(object sender, EventArgs e)
        {
            FormPayService payService = new();  
            openFormInsidePanel(payService);
        }

        private void panelScreen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}