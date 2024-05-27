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

namespace DesktopBankUI
{
    public partial class FormTransactions : Form
    {
        int id;
        Account _currentAccount;

        private readonly NojedaisticDesktopBankContext _context;
        private readonly IOperationRepository _operationRepository;
        private readonly AccountInfoService _accountInfoService;

        public FormTransactions(Account currentAccount, NojedaisticDesktopBankContext context, IOperationRepository operationRepository, AccountInfoService accountInfoService)
        {
            _accountInfoService = accountInfoService;
            _operationRepository = operationRepository;
            _context = context;
            _currentAccount = currentAccount;
            id = currentAccount.AccountId;

            InitializeComponent();
        }

        private void FormTransactions_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener transacciones
                var sourceTransactions = _operationRepository.GetOperationsBySenderCBU(id);
                var destinationTransactions = _operationRepository.GetOperationsByReceiverCBU(id);

                // Combinar origen y destino
                var transactions = sourceTransactions.Union(destinationTransactions);

                // Crear lista de objetos para el DataGridView
                var transactionList = transactions.Select(t => new
                {
                    ColumnSource = t.SourceAccount.AccountAlias,
                    ColumnDestination = t.DestinationAccount.AccountAlias,
                    ColumnAmount = t.OperationAmount,
                    ColumnTransaction = t.OperationCode.OperationCode1
                }).ToList();

                // Mostrar el contenido de la lista en un MessageBox
                if (transactionList.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var transaction in transactionList)
                    {
                        sb.AppendLine($"Source: {transaction.ColumnSource}, Destination: {transaction.ColumnDestination}, Amount: {transaction.ColumnAmount}, Transaction: {transaction.ColumnTransaction}");
                    }

                    MessageBox.Show(sb.ToString(), "Transacciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontraron transacciones.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Asignar la lista como fuente de datos del DataGridView
                DataGridTransactions.DataSource = transactionList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las transacciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTransactions(int currentAccountId)
        {
            try
            {
                // Obtener transacciones
                var sourceTransactions = _operationRepository.GetOperationsBySenderCBU(currentAccountId);
                var destinationTransactions = _operationRepository.GetOperationsByReceiverCBU(currentAccountId);

                // Combinar origen y destino
                var transactions = sourceTransactions.Union(destinationTransactions);

                // Crear lista de objetos para el DataGridView
                var transactionList = transactions.Select(t => new
                {
                    ColumnSource = t.SourceAccount.AccountAlias,
                    ColumnDestination = t.DestinationAccount.AccountAlias,
                    ColumnAmount = t.OperationAmount,
                    ColumnTransaction = t.OperationCode.OperationCode1
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

    }
}