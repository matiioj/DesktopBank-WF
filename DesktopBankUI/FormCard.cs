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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DesktopBankUI
{
    public partial class FormCard : Form
    {
        ICollection<Card> ListCards = new List<Card>();
        string numtc;
        DateTime expirationdate;
        byte cvv;
        string name;
        string surname;
        string mes;
        string anio;
        string fechaConFormato;
        string numeroConFormato;

        // Combina el mes y el año en el formato deseado


        public FormCard(Account currentAccount)
        {
            numtc = string.Empty;
            mes = string.Empty;
            anio = string.Empty;
            fechaConFormato = string.Empty;
            numeroConFormato = string.Empty;
            cvv = 0;
            name = string.Empty;
            surname = string.Empty;
            ListCards = currentAccount.Cards;
            foreach (Card card in ListCards)
            {
                numtc = card.CardNumber;
                numeroConFormato = string.Join(" ", Enumerable.Range(0, numtc.Length / 4).Select(i => numtc.Substring(i * 4, 4)));
                expirationdate = card.CardExpirationDate;
                mes = expirationdate.ToString("MM");
                anio = expirationdate.ToString("yy");
                fechaConFormato = $"{mes}/{anio}";
                cvv = card.CardCvv;

            }
            name = currentAccount.User.Client.ClientName;
            surname = currentAccount.User.Client.ClientSurname;
            InitializeComponent();
            CargarDatos_Tarjeta();

        }

        private void FormCard_Load(object sender, EventArgs e)
        {

        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EtqTcNumber.Text);
            MessageBox.Show("Su número ha sido copiado con éxito");
        }

        private void gBoxTarjetaDeCredito_Enter(object sender, EventArgs e)
        {

        }

        public void CargarDatos_Tarjeta()
        {
            EtqTcNumber.Text = numeroConFormato;
            EtqCodigoSeguridad.Text = cvv.ToString("D3");
            EtqFechaVencimiento.Text = fechaConFormato;
            EtqNombreUsuario.Text = name;
            EtqApellidoUsuario.Text = surname;


        }

        private void EtqApellidoUsuario_Click(object sender, EventArgs e)
        {

        }

        private void EtqTcNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
