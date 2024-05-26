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
    public partial class FormExtract : Form
    {
        Account _currentAccount;

        private readonly AccountInfoService _accountInfoService;
        private readonly ExtractBalanceService _extractBalanceService;
        public FormExtract(Account currentAccount, ExtractBalanceService extractBalanceService, AccountInfoService accountInfoService)
        {
            _extractBalanceService = extractBalanceService;
            _accountInfoService = accountInfoService;
            _currentAccount = currentAccount;
            InitializeComponent();
            //cargar ventana en el medio de home
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormExtract_Load(object sender, EventArgs e)
        {

        }

        private async void BtnExtract_Click(object sender, EventArgs e)
        {
            if (_currentAccount.AccountBalance == 0) //check account balance
            {
                MessageBox.Show("no tiene saldo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(TxtAmount.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    if (amount <= _currentAccount.AccountBalance)
                    {
                        await _extractBalanceService.ExtractBalanceFromAccount(_currentAccount, amount);
                        MessageBox.Show("extraccion realizada", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("la solicitud excede el saldo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("valor invalido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("cantidad no valida", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
