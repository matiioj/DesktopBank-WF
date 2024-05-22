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
    public partial class FormProfile : Form
    {
        string cbu;
        string alias;
        int CUIL;
        public FormProfile(Account currentAccount)
        {
            cbu = currentAccount.AccountCbu.ToString();
            alias = currentAccount.AccountAlias;

            InitializeComponent();
            Datos_Usuario();
        }


        public void Datos_Usuario()
        {
            LabelContenidoAlias.Text = alias;
            LabelContenidoCbu.Text = cbu;

        }
        private void FormProfile_Load(object sender, EventArgs e)
        {

        }

        private void LabelPerfil_Click(object sender, EventArgs e)
        {

        }

        private void LabelCbu_Click(object sender, EventArgs e)
        {

        }

        private void LabelContenidoCbu_Click(object sender, EventArgs e)
        {

        }

        private void LabelContenidoCuil_Click(object sender, EventArgs e)
        {

        }

        private void LabelContenidoNumCuenta_Click(object sender, EventArgs e)
        {

        }

        private void LabelContenidoAlias_Click(object sender, EventArgs e)
        {

        }
    }
}
