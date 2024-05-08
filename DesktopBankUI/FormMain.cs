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
    public partial class FormMain : Form
    {
        private int borderSize = 1;


        public FormMain()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.Teal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

    }
}
