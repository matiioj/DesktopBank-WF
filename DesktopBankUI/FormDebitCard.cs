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
    public partial class FrmCreditCard : Form
    {
        public FrmCreditCard()
        {
            InitializeComponent();
        }

        private void FrmCreditCard_Load(object sender, EventArgs e)
        {

        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EtqTcNumber.Text); //SetText, Permite copiar texto al portapapeles. Método de la clase Clipboard. 
            MessageBox.Show("Su número ha sido copiado con éxito");
        }
    }
}
