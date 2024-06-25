using DesktopBank.Services;
using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.Services;
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

namespace DesktopBankUI
{
    public partial class FormPayService : Form
    {
        private Account _currentAccount;
        private readonly CreateTransferService _createTransferService;
        private readonly CheckAccountTransfer _checkAccountTransfer;
        public FormPayService(Account currentAccount, CheckAccountTransfer checkAccountTransfer, CreateTransferService createTransferService)
        {
            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            _checkAccountTransfer = checkAccountTransfer;
            InitializeComponent();
        }

        private void btnAysa_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = "6868126544111186218";
            if (datoDeCuenta.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var destinationAccount = (_checkAccountTransfer.ExecuteChecker(datoDeCuenta));
                    if (destinationAccount != null)
                    {
                        FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService);
                        formConfirmTransferencia.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgip_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = "4977913668524161862";
            if (datoDeCuenta.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var destinationAccount = (_checkAccountTransfer.ExecuteChecker(datoDeCuenta));
                    if (destinationAccount != null)
                    {
                        FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService);
                        formConfirmTransferencia.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEdesur_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = "";
            if (datoDeCuenta.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var destinationAccount = (_checkAccountTransfer.ExecuteChecker(datoDeCuenta));
                    if (destinationAccount != null)
                    {
                        FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService);
                        formConfirmTransferencia.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnMetrogas_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = "8124986118788514428";
            if (datoDeCuenta.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var destinationAccount = (_checkAccountTransfer.ExecuteChecker(datoDeCuenta));
                    if (destinationAccount != null)
                    {
                        FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService);
                        formConfirmTransferencia.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                    {
                        MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
