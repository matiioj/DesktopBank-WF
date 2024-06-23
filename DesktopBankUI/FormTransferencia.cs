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

namespace DesktopBankUI
{
    public partial class FormTransferencia : Form
    {
        Account _currentAccount;
        private readonly CreateTransferService _createTransferService;
        public FormTransferencia(Account currentAccount, CreateTransferService createTransferService)
        {
            InitializeComponent();
        }

        private void BtnPegarClipboard_Click(object sender, EventArgs e)
        {

        }



        private void botonVolver_Click(object sender, EventArgs e)
        {

            this.Hide(); // oculta FormTransferencia
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {
            var datoDeCuenta = TxtBoxDatosCuenta.Text;
            if (datoDeCuenta.IsNullOrEmpty()) 
            {
                MessageBox.Show("Por favor, indique un CBU o Alias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
            }
        }
    }
}
