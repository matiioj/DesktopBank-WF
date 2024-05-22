using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBankUI
{
    public partial class FormHome : Form
    {
        string currencySign;
        string balance;
        string nombre;
        public FormHome(Account currentAccount)
        {
            nombre = currentAccount.User.UserName;
            currencySign = currentAccount.AccountCurrencyNavigation.CurrencySign;
            balance = Convert.ToString(currentAccount.AccountBalance);
            InitializeComponent();
            Load_Label();
            Hello_Label(nombre);
        }

        public void Load_Label()
        {
            labelBalance.Text = currencySign + balance;
        }


        public void Hello_Label(string nombre)
        {
            LabelBienvenido.Text = $"Bienvenido {nombre}";
        }
        private void LabelBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void labelBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
