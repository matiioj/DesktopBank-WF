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


namespace DesktopBankUI
{
    public partial class FormHome : Form
    {
        int id;
        string currencySign;
        string balance;
        string nombre;
        Account _currentAccount;

        private readonly AccountInfoService _accountInfoService;
        private readonly DepositBalanceService _depositBalanceService;
        private readonly ExtractBalanceService _extractBalanceService;

        public FormHome(Account currentAccount, DepositBalanceService depositBalanceService, AccountInfoService accountInfoService, ExtractBalanceService extractBalanceService)
        {
            _depositBalanceService = depositBalanceService;
            _extractBalanceService = extractBalanceService;
            _accountInfoService = accountInfoService;
            _currentAccount = currentAccount;
            id = currentAccount.AccountId;

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
        /*
        private async void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(TxtAmount.Text, out decimal amount))
                {
                    await _depositBalanceService.DepositBalanceFromAccount(_currentAccount, amount);
                    _currentAccount = _accountInfoService.GetAccountByUserId(_currentAccount.UserId);
                    Load_Labels();
                }
                else
                {
                    MessageBox.Show($"Ocurrió un error al depositar: {TxtAmount.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al depositar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        */

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

        /*
        private async void extractButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(TxtAmount.Text, out decimal amount))
                {
                    await _extractBalanceService.ExtractBalanceFromAccount(_currentAccount, amount);
                    _currentAccount = _accountInfoService.GetAccountByUserId(_currentAccount.UserId);
                    Load_Labels();
                }
                else
                {
                    MessageBox.Show($"Ocurrió un error al extraer: {TxtAmount.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al extraer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        */

    }
}