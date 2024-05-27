using Microsoft.IdentityModel.Tokens;
using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopBank.Services;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.BusinessObjects.Interfaces;


namespace DesktopBankUI
{
    public partial class FormHome : Form
    {
        int id;
        string currencySign;
        string balance;
        string nombre;
        Account _currentAccount;

        private readonly NojedaisticDesktopBankContext _context;
        private readonly AccountInfoService _accountInfoService;
        private readonly DepositBalanceService _depositBalanceService;
        private readonly ExtractBalanceService _extractBalanceService;
        private readonly IOperationRepository _operationRepository;

        public FormHome(Account currentAccount, NojedaisticDesktopBankContext context, DepositBalanceService depositBalanceService, AccountInfoService accountInfoService, ExtractBalanceService extractBalanceService, IOperationRepository operationRepository)
        {
            _context = context;
            _currentAccount = currentAccount;
            id = currentAccount.AccountId;
            _accountInfoService = accountInfoService;
            _depositBalanceService = depositBalanceService;
            _extractBalanceService = extractBalanceService;
            _operationRepository = operationRepository;

            InitializeComponent();
            Load_Labels();
        }

        public void Load_Labels()
        {
            currencySign = _currentAccount.AccountCurrencyNavigation.CurrencySign;
            nombre = _currentAccount.User.Client.ClientName;
            balance = Convert.ToString(_currentAccount.AccountBalance);
            labelBalance.Text = currencySign + balance;
            LabelBienvenido.Text = $"Bienvenido {nombre.ToUpper()}";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var formDeposit = new FormDeposit(_currentAccount, _depositBalanceService, _accountInfoService);
            try
            {
                formDeposit.ShowDialog();
                _currentAccount = _accountInfoService.GetAccountByUserId(_currentAccount.UserId);
                Load_Labels();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al abrir el formulario de depósito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void extractButton_Click(object sender, EventArgs e)
        {
            var formExtract = new FormExtract(_currentAccount, _extractBalanceService, _accountInfoService);
            try
            {
                formExtract.ShowDialog();
                _currentAccount = _accountInfoService.GetAccountByUserId(_currentAccount.UserId);
                Load_Labels();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al abrir el formulario de extracción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }

    }
}