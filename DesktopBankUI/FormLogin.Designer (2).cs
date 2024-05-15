using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DesktopBankUI
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            TxtPassword = new TextBox();
            TxtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnIniciar = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Controls.Add(TxtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(68, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de inicio";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(98, 52);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(172, 23);
            TxtPassword.TabIndex = 3;
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(98, 22);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(172, 23);
            TxtUser.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // BtnIniciar
            // 
            BtnIniciar.Location = new Point(287, 189);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(75, 23);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(68, 192);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(174, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No tienes usuario, registrate?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 254);
            Controls.Add(linkLabel1);
            Controls.Add(BtnIniciar);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtPassword;
        private TextBox TxtUser;
        private Label label2;
        private Label label1;
        private Button BtnIniciar;
        private LinkLabel linkLabel1;
    }
}