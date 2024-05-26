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
    public partial class FormCard : Form
    {
        public FormCard()
        {
            InitializeComponent();
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
    }
}
