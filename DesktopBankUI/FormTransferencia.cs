using DesktopBank.BusinessObjects.Generated.Models;
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
        public FormTransferencia(Account currentAccount, CheckAccountTransfer checkAccountTransfer, CreateTransferService createTransferService)
        {
            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            _checkAccountTransfer = checkAccountTransfer;
            InitializeComponent();
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            var datoDeCuenta = TxtBoxDatosCuenta.Text;
            if (datoDeCuenta.IsNullOrEmpty())
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var destinationAccount = (_checkAccountTransfer.ExecuteChecker(datoDeCuenta));
                if (destinationAccount != null)
                {
                    FormConfirmTransferencia formConfirmTransferencia = new(_currentAccount, destinationAccount, _createTransferService);
                    formConfirmTransferencia.ShowDialog();
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
