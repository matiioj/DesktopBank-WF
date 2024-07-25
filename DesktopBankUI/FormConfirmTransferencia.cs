using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.BusinessObjects.Models;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
//using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Automation;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBankUI
{
    public partial class FormConfirmTransferencia : Form
    {
        private readonly OperationRepository _operationRepository;
        private readonly CreateReceiptService _createReceiptService;
        private readonly FormatToReceiptService _formatToReceiptService;
        private MailService mailService = new MailService();
        private Account _currentAccount;
        private Account _destinationAccount;
        private readonly CreateTransferService _createTransferService;
        public FormConfirmTransferencia(Account currentAccount, Account destinationAccount, CreateTransferService createTransferService, OperationRepository operationRepository)
        {
            _operationRepository = operationRepository;
            _formatToReceiptService = new(operationRepository);
            _createReceiptService = new(_formatToReceiptService);

            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            _destinationAccount = destinationAccount;
            InitializeComponent();
            decimal saldo = _currentAccount.AccountBalance;
            string saldoDisponible = "Saldo disponible: " + _currentAccount.AccountCurrencyNavigation.CurrencySign + saldo;
            string nombre = (_destinationAccount.User.Client.ClientName + " " + _destinationAccount.User.Client.ClientSurname).ToUpper();
            availableBalanceTxt.Text = saldoDisponible;
            personToTransferTxt.Text = "Vas a transferirle a\n" + nombre;
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
                        //_createReceiptService.CreateReceipt(_currentAccount, _destinationAccount);
                        var currentAccountMail = _currentAccount.User.Client.ClientEmail;
                        var destinationAccountMail = _destinationAccount.User.Client.ClientEmail;
                        MailData mailData = new MailData();
                        mailData.MailTo = currentAccountMail;
                        mailData.Subject = "Su transferencia se ha realizado con éxito";
                        mailData.Body = $"Ha transferido $ {amount} a {_destinationAccount.User.Client.ClientName}";
                        mailService.SendMail(mailData);
                        mailData.MailTo = destinationAccountMail;
                        mailData.Subject = $"Ha recibido una nueva transferencia de dinero";
                        mailData.Body = $"Ha recibido $ {amount} de {_currentAccount.User.Client.ClientName}";
                        mailService.SendMail(mailData);
                        MessageBox.Show("Transferencia realizada con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.Close();

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

        private void btnGuardarComprobante_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string route = saveFileDialog1.FileName;
                int operationId = _operationRepository.GetLastOperationBySenderCBU(_currentAccount.AccountCbu).OperationId;
                _createReceiptService.CreateReceipt(operationId, route);
                this.Close();
            }

        }
    }
}
