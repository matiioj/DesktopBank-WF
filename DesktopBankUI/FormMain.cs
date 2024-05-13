using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DesktopBankUI
{
    public partial class FormMain : Form
    {
        private int borderSize = 1;

        // Make a dragable window without border calling Windows API 
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FormMain()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.Teal;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restoreButton.Visible = true;
            maximizeButton.Visible = false;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restoreButton.Visible = false;
            maximizeButton.Visible = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBanner_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }

        private void openFormInsidePanel(Form functionForm)
        {
            if (this.panelScreen.Controls.Count > 0)
            {
                this.panelScreen.Controls.RemoveAt(0);
            }
            functionForm.TopLevel = false;
            functionForm.Dock = DockStyle.Fill;
            this.panelScreen.Controls.Add(functionForm);
            this.panelScreen.Tag = functionForm;
            functionForm.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }
        /*
        private void profileButton_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new();
            openFormInsidePanel(profileForm);
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            FormCard cardForm = new();
            openFormInsidePanel(cardForm);
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            FormTransfer transferForm = new();
            openFormInsidePanel(transferForm);
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            FormTransactions transactionsForm = new();
            openFormInsidePanel(transactionsForm);
        }*/
    }
}
