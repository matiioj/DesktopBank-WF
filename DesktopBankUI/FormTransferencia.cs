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
            LoadContactosRecientes(_currentAccount.AccountCbu);
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
                        //compara el AccountCurrency de la cuenta actual (_currentAccount) 
                        //con el de la cuenta de destino (destinationAccount) 
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

        private void LoadContactosRecientes(long cbu)
        {
            try
            {
                // Obtener transacciones
                var sourceTransactions = _operationRepository.GetOperationsBySenderCBU(cbu);

                var transactions = sourceTransactions
                    .Where(t => t.SourceAccount.AccountCbu != t.DestinationAccount.AccountCbu)
                    .OrderByDescending(t => t.OperationDate);


                var recientesList = transactions.Select(t => new
                {
                    Name = t.DestinationAccount.User.Client.ClientName.ToUpper() + " " + t.DestinationAccount.User.Client.ClientSurname.ToUpper(),
                    CBU = t.DestinationAccount.AccountCbu
                })
                    .Distinct()
                    .ToList();

                if (recientesList.Count == 0)
                {
                    labelRecientes.Visible = false;
                    listaRecientes.Visible = false;
                }
                else
                {
                    // Asignar la lista como fuente de datos del DataGridView
                    listaRecientes.DataSource = recientesList;
                    listaRecientes.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción mostrando un mensaje de error
                MessageBox.Show($"Error al cargar las transacciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListaRecientes_MouseClick(object sender, MouseEventArgs e)
        {
            int index = listaRecientes.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {

                var selectedContact = listaRecientes.Items[index] as dynamic;
                string selectedCBU = Convert.ToString(selectedContact.CBU);
                listaRecientes.ClearSelected();
                var datoDeCuenta = selectedCBU;


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
        }
    }
}