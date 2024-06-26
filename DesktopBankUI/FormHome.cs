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
        private readonly AccountStateService _accountStateService; //*

        public FormHome(Account currentAccount, NojedaisticDesktopBankContext context, DepositBalanceService depositBalanceService, AccountInfoService accountInfoService, ExtractBalanceService extractBalanceService, IOperationRepository operationRepository, AccountStateService accountStateService) //* (AccountStateService accountStateService)
        {
            _context = context;
            _currentAccount = currentAccount;
            id = currentAccount.AccountId;
            _accountInfoService = accountInfoService;
            _depositBalanceService = depositBalanceService;
            _extractBalanceService = extractBalanceService;
            _operationRepository = operationRepository;
            _accountStateService = accountStateService; //*

            InitializeComponent();
            Load_Labels();
            Load_UserAccounts();
        }

        public void Load_Labels()
        {
            if (_currentAccount == null)
            {
                MessageBox.Show("No se ha seleccionado ninguna cuenta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            currencySign = _currentAccount.AccountCurrencyNavigation?.CurrencySign ?? "N/D";
            nombre = _currentAccount.User?.Client?.ClientName ?? "N/D";
            balance = Convert.ToString(_currentAccount.AccountBalance);
            labelBalance.Text = currencySign + balance;
            LabelBienvenido.Text = $"Bienvenido {nombre.ToUpper()}";
            
        }

        private void Load_UserAccounts()
        {
            var accounts = _accountInfoService.GetAllAccountsByUserId(_currentAccount.UserId);

            if (accounts == null || !accounts.Any())
            {
                comboBoxAccounts.DataSource = null;
                comboBoxAccounts.Items.Clear();
                comboBoxAccounts.Items.Add("No se encontró ninguna cuenta");
                return;
            }

            var accountList = accounts.Select(account => new
            {
                AccountId = account.AccountId,
                AccountDescription = $"{GetCurrencyName(account.AccountCurrency)} ({account.AccountCurrency})"
            }).ToList();

            comboBoxAccounts.DataSource = accountList;
            comboBoxAccounts.DisplayMember = "AccountDescription";
            comboBoxAccounts.ValueMember = "AccountId";
        }

        private string GetCurrencyName(int accountCurrency)
        {
            return accountCurrency switch
            {
                1 => "Pesos",
                2 => "Dólar",
                3 => "Euro",
                _ => "Desconocida",
            };
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

        private void ChangeCurrencyButton_Click(object sender, EventArgs e)
        {
            var selectedAccountId = (int)comboBoxAccounts.SelectedValue;
            _currentAccount = _accountInfoService.GetAccountById(selectedAccountId);
            Load_Labels();
        }

        private void labelBalance_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}