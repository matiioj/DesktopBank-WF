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
        long cbu;
        Account _currentAccount;

        private readonly NojedaisticDesktopBankContext _context;
        private readonly OperationRepository _operationRepository;
        private readonly AccountInfoService _accountInfoService;
        private readonly ManageOperationsService _manageOperationsService;

        public FormTransactions(Account currentAccount, NojedaisticDesktopBankContext context, OperationRepository operationRepository, AccountInfoService accountInfoService, ManageOperationsService manageOperationsService)
        {
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
                    From = (t.SourceAccount.User.Client.ClientName.ToUpper()) + " " + (t.SourceAccount.User.Client.ClientSurname.ToUpper()),
                    To = (t.DestinationAccount.User.Client.ClientName.ToUpper())+ " " + (t.DestinationAccount.User.Client.ClientSurname.ToUpper()),
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

    }
}