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
    public partial class FormDeposit : Form
    {
        Account _currentAccount;

        private readonly AccountInfoService _accountInfoService;
        private readonly DepositBalanceService _depositBalanceService;
        public FormDeposit(Account currentAccount, DepositBalanceService depositBalanceService, AccountInfoService accountInfoService)
        {
            _depositBalanceService = depositBalanceService;
            _accountInfoService = accountInfoService;
            _currentAccount = currentAccount;
            InitializeComponent();
            //cargar ventana en el medio de home
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormDeposit_Load(object sender, EventArgs e)
        {

        }

        private async void BtnDepo_Click(object sender, EventArgs e)
        {
            //si tryparse da true amount almacena el valor sino almacena 0
            if (decimal.TryParse(TxtAmount.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    await _depositBalanceService.DepositBalanceFromAccount(_currentAccount, amount);
                    MessageBox.Show("deposito realizado", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
