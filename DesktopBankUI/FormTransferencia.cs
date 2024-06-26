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
using DesktopBank.BusinessObjects.Generated.Models;

namespace DesktopBankUI
{
    public partial class FormTransferencia : Form
    {
        private readonly AccountStateService _accountStateService;//*
        private Account _currentAccount;
        public FormTransferencia(AccountStateService accountStateService)
        {

            _accountStateService = accountStateService;
            _currentAccount = _accountStateService.GetCurrentAccount();

            InitializeComponent();
        }

        private void BtnPegarClipboard_Click(object sender, EventArgs e)
        {

            // Declara un IDataObject para contener los datos devueltos del portapapeles.
            // Obtiene los datos del portapapeles.
            IDataObject datoEnClipboard = Clipboard.GetDataObject();

            // Determina si los datos están en un formato valido.
            if (datoEnClipboard.GetDataPresent(DataFormats.Text))
            {
                // Si: muestra en el cuadro de texto.
                TxtBoxDatosCuenta.Text = (string)datoEnClipboard.GetData(DataFormats.Text);
            }
            else
            {
                // No: da el siguiente error en el cuadro de texto
                TxtBoxDatosCuenta.Text = "No se pudieron recuperar datos del portapapeles.";
            }

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {

            this.Hide(); // oculta FormTransferencia
        }
    }
}
