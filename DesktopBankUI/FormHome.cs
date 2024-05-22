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
        public FormHome(Account currentAccount)
        {
            currencySign = currentAccount.AccountCurrencyNavigation.CurrencySign;
            balance = Convert.ToString(currentAccount.AccountBalance);
            InitializeComponent();
            Load_Label();
        }

        public void Load_Label()
        {
            labelBalance.Text = currencySign + balance;
        }


    }
}
