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

                // Combinar origen y destino
                var transactions = sourceTransactions.Union(destinationTransactions).OrderByDescending(t => t.OperationDate);

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
                    // Si la lista está vacía, mostrar un mensaje o realizar alguna acción
                    MessageBox.Show("No se encontraron transacciones.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Asignar la lista como fuente de datos del DataGridView
                    DataGridTransactions.DataSource = transactionList;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
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

                MessageBox.Show($"Transaction Details:\nFrom: {from}\nTo: {to}\nType: {type}\nDate: {date}\nAmount: {amount}", "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarComprobante(Convert.ToInt32(id));
            }
        }

        private void GuardarComprobante(int operationId)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string route = saveFileDialog1.FileName;
                _createReceiptService.CreateReceipt(operationId, route);
            }

        }
    }
}