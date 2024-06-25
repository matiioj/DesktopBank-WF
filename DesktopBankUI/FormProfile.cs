using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
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
        NojedaisticDesktopBankContext _context;
        AccountRepository _accountRepository;
        Account _account;
        public FormProfile(Account currentAccount, NojedaisticDesktopBankContext context)
        {

            cbu = currentAccount.AccountCbu.ToString();
            alias = currentAccount.AccountAlias;
            CUIL = currentAccount.User.Client.ClientCuil;
            _account = currentAccount;
            _context = context;
            _accountRepository = new AccountRepository(_context);

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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LabelContenidoCbu.Text);
            MessageBox.Show("Su número ha sido copiado con éxito");
        }

        private void LabelPerfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyAlias_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LabelContenidoAlias.Text);
            MessageBox.Show("Su Alias ha sido copiado con éxito");
        }

        private void btnCambiarAlias_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = true;
        }

        private void panelCambiarAlias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelarAlias_Click(object sender, EventArgs e)
        {
            panelCambiarAlias.Visible = false;
        }

        private void btnAceptarAlias_Click(object sender, EventArgs e)
        {
            string aliasNuevo = txtCambiarAlias.Text;
            _account.AccountAlias = aliasNuevo;
            _accountRepository.Update(_account);
            _context.SaveChanges(); 
        }
    }
}
