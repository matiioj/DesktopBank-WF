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
    }
}
