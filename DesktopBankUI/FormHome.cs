using DesktopBank.BusinessObjects.Generated.Models;
using Microsoft.IdentityModel.Tokens;
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
<<<<<<< HEAD
        public FormHome(Account currentAccount)
        {
            nombre = currentAccount.User.Client.ClientName;
            currencySign = currentAccount.AccountCurrencyNavigation.CurrencySign;
            balance = Convert.ToString(currentAccount.AccountBalance);
=======
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



>>>>>>> origin/operationRepositories

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
<<<<<<< HEAD
=======

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
>>>>>>> origin/operationRepositories
    }
}
