using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Models;
using DesktopBank.Services;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBankUI
{
    public partial class FormConfirmTransferencia : Form
    {
        private Account _currentAccount;
        private Account _destinationAccount;
        private readonly CreateTransferService _createTransferService;
        public FormConfirmTransferencia(Account currentAccount, Account destinationAccount, CreateTransferService createTransferService)
        {
            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            _destinationAccount = destinationAccount;
            InitializeComponent();
            string nombre = (_destinationAccount.User.Client.ClientName + " " + _destinationAccount.User.Client.ClientName).ToUpper();
            personToTransferTxt.Text = "Vas a transferirle a \n   " + nombre;
            this.StartPosition = FormStartPosition.CenterParent;
        }



        private async void BtnTransferir_Click(object sender, EventArgs e)
        {
            //si tryparse da true amount almacena el valor sino almacena 0
            if (decimal.TryParse(TxtAmount.Text, out decimal amount))
            {
                if (amount > 0)
                {
                    try
                    { 
                        await _createTransferService.ExecuteTransfer(_currentAccount, amount, _destinationAccount);
                        MessageBox.Show("La transferencia fue realizada");
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al transferir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show($"Error: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Introduzca un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduzca un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
