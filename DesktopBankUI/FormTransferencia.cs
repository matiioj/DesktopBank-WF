using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBankUI
{
    public partial class FormTransferencia : Form
    {
        public FormTransferencia()
        {
            InitializeComponent();
        }

        private void BtnPegarClipboard_Click(object sender, EventArgs e)
        {

        }



        private void botonVolver_Click(object sender, EventArgs e)
        {

            this.Hide(); // oculta FormTransferencia
        }

        private void FormTransferencia_Load(object sender, EventArgs e)
        {

        }
    }
}
