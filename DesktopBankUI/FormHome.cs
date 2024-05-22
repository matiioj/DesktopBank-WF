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
            nombre = (currentAccount.User.Client.ClientName).ToUpper();
            currencySign = currentAccount.AccountCurrencyNavigation.CurrencySign;
            balance = Convert.ToString(currentAccount.AccountBalance);

            InitializeComponent();
            Load_Labels();
        }

        public void Load_Labels()
        {
            labelBalance.Text = currencySign + balance;
            LabelBienvenido.Text = $"Bienvenido {nombre}";
        }
    }
}
