using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.Win32;
using System.Globalization;

namespace DesktopBankUI
{
    public partial class FormTransactions : Form
    {
        int id;
        long cbu;
        Account _currentAccount;

        private readonly NojedaisticDesktopBankContext _context;
        private readonly OperationRepository _operationRepository;
        private readonly AccountInfoService _accountInfoService;
        private readonly ManageOperationsService _manageOperationsService;
        private readonly CreateReceiptService _createReceiptService;
        private readonly FormatToReceiptService _formatToReceiptService;

        private int _depositCount;
        private int _withdrawalCount;
        private int _transferCount;

        public FormTransactions(Account currentAccount, NojedaisticDesktopBankContext context, OperationRepository operationRepository, AccountInfoService accountInfoService, ManageOperationsService manageOperationsService)
        {
            _formatToReceiptService = new(operationRepository);
            _createReceiptService = new(_formatToReceiptService);
            _manageOperationsService = manageOperationsService;
            _accountInfoService = accountInfoService;
            _operationRepository = operationRepository;
            _context = context;
            _currentAccount = currentAccount;
            id = currentAccount.AccountId;
            cbu = currentAccount.AccountCbu;

            InitializeComponent();
            LoadTransactions(cbu);
        }

        private void LoadTransactions(long cbu)
        {
            try
            {
                // Obtener transacciones
                var sourceTransactions = _operationRepository.GetOperationsBySenderCBU(cbu);
                var destinationTransactions = _operationRepository.GetOperationsByReceiverCBU(cbu);

                // Combinar origen y destino eliminando duplicados
                var transactions = sourceTransactions.Union(destinationTransactions, new OperationComparer()).OrderByDescending(t => t.OperationDate);

                // Contar transacciones de cada tipo
                _transferCount = transactions.Count(t => t.OperationCode.OperationCodeNumber == 3);
                _depositCount = transactions.Count(t => t.OperationCode.OperationCodeNumber == 1);
                _withdrawalCount = transactions.Count(t => t.OperationCode.OperationCodeNumber == 2);

                // Crear lista de objetos para el DataGridView
                var transactionList = transactions.Select(t => new
                {
                    Id = t.OperationId,
                    From = (t.SourceAccount.User.Client.ClientName.ToUpper()) + " " + (t.SourceAccount.User.Client.ClientSurname.ToUpper()),
                    To = (t.DestinationAccount.User.Client.ClientName.ToUpper()) + " " + (t.DestinationAccount.User.Client.ClientSurname.ToUpper()),
                    Type = t.OperationCode.OperationCodeDescription,
                    Date = t.OperationDate,
                    Amount = _manageOperationsService.GetSignedAmount(t, cbu)
                }).ToList();

                // Verificar si la lista de transacciones está vacía
                if (transactionList.Count == 0)
                {
                    MessageBox.Show("No se encontraron transacciones.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataGridTransactions.DataSource = transactionList;
                }

                // Mostrar los valores calculados en controles del formulario
                lblDepositTotal.Text = $"Número de depósitos: {_depositCount}";
                lblWithdrawalTotal.Text = $"Número de retiros: {_withdrawalCount}";
                lblTransferCount.Text = $"Número de transferencias: {_transferCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las transacciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is clicked (not the header row)
            if (e.RowIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = DataGridTransactions.Rows[e.RowIndex];

                // Perform the desired action with the clicked row
                // Example: Display details of the selected transaction
                string id = clickedRow.Cells["Id"].Value.ToString();
                string from = clickedRow.Cells["From"].Value.ToString();
                string to = clickedRow.Cells["To"].Value.ToString();
                string type = clickedRow.Cells["Type"].Value.ToString();
                DateTime date = Convert.ToDateTime(clickedRow.Cells["Date"].Value);
                decimal amount = Convert.ToDecimal(clickedRow.Cells["Amount"].Value);

                var result = MessageBox.Show($"Transaction Details:\nFrom: {from}\nTo: {to}\nType: {type}\nDate: {date}\nAmount: {amount}\n\nDo you want to save the receipt?", "Confirm Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GuardarComprobante(Convert.ToInt32(id));
                }
            }
        }

        private void GuardarComprobante(int operationId)
        {
            var operationDate = _operationRepository.GetOperation(operationId).OperationDate.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            saveFileDialog1.FileName = $"{operationDate.Replace("-", "")}_{operationId}.pdf";
            saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog1.DefaultExt = "pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string route = saveFileDialog1.FileName;
                _createReceiptService.CreateReceipt(operationId, route);
            }
        }
    }
}