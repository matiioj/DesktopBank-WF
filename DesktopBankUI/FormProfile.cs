using DesktopBank.BusinessObjects.Generated.Models;
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

namespace DesktopBankUI
{
    public partial class FormProfile : Form
    {
        string cbu;
        string alias;
        long CUIL;
        private readonly AccountStateService _accountStateService;//*
        public FormProfile(Account currentAccount, AccountStateService accountStateService)
        {
            cbu = currentAccount.AccountCbu.ToString();
            alias = currentAccount.AccountAlias;
            CUIL = currentAccount.User.Client.ClientCuil;
            _accountStateService = accountStateService;

            InitializeComponent();
            CargarDatos_Usuario();
        }


        public void CargarDatos_Usuario()
        {
            LabelContenidoAlias.Text = alias;
            LabelContenidoCbu.Text = cbu;
            LabelContenidoCuil.Text = Convert.ToString(CUIL);
        }

        private void LabelContenidoCbu_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
