using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;

namespace DesktopBankUI
{
    public partial class FormTransferencia : Form
    {
        private Account _currentAccount;
        private readonly CreateTransferService _createTransferService;
        private readonly CheckAccountTransfer _checkAccountTransfer;
        private readonly OperationRepository _operationRepository;
        public FormTransferencia(Account currentAccount, CheckAccountTransfer checkAccountTransfer, CreateTransferService createTransferService, OperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            _checkAccountTransfer = checkAccountTransfer;
            InitializeComponent();
        }

        private async void BtnTransfer_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = TxtBoxDatosCuenta.Text;
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
                        if (_currentAccount.AccountCurrency != destinationAccount.AccountCurrency)
                        {
                            MessageBox.Show("No se permite transferir entre cuentas con distintas monedas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService, _operationRepository);
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



        private void botonVolver_Click(object sender, EventArgs e)
        {

            this.Hide(); // oculta FormTransferencia
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            
        }
    }
}
