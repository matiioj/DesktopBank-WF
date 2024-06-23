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
            TxtPassword = new TextBox();
            TxtUser = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            iconoChancho = new PictureBox();
            panelCampos = new Panel();
            exitButton = new Button();
            registerLabel = new Label();
            botonIniciarSesion = new Button();
            contraseñaIniciarSesion = new FontAwesome.Sharp.IconButton();
            nombreIniciarSesion = new FontAwesome.Sharp.IconButton();
            panelIniciarSesion = new Panel();
            tituloIniciarSesion = new Label();
            linkChangePass = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoChancho).BeginInit();
            panelCampos.SuspendLayout();
            panelIniciarSesion.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.LightCyan;
            TxtPassword.Location = new Point(233, 107);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(244, 31);
            TxtPassword.TabIndex = 3;
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.LightCyan;
            TxtUser.Location = new Point(233, 28);
            TxtUser.Margin = new Padding(4, 5, 4, 5);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(244, 31);
            TxtUser.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(iconoChancho);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 323);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 348);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 110);
            panel3.TabIndex = 6;
            // 
            // iconoChancho
            // 
            iconoChancho.BackColor = Color.Teal;
            iconoChancho.Image = Properties.Resources.iconPig;
            iconoChancho.Location = new Point(153, 52);
            iconoChancho.Margin = new Padding(4, 5, 4, 5);
            iconoChancho.Name = "iconoChancho";
            iconoChancho.Size = new Size(249, 257);
            iconoChancho.SizeMode = PictureBoxSizeMode.Zoom;
            iconoChancho.TabIndex = 0;
            iconoChancho.TabStop = false;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.FromArgb(14, 102, 85);
            panelCampos.Controls.Add(linkChangePass);
            panelCampos.Controls.Add(exitButton);
            panelCampos.Controls.Add(registerLabel);
            panelCampos.Controls.Add(botonIniciarSesion);
            panelCampos.Controls.Add(contraseñaIniciarSesion);
            panelCampos.Controls.Add(TxtPassword);
            panelCampos.Controls.Add(nombreIniciarSesion);
            panelCampos.Controls.Add(TxtUser);
            panelCampos.Dock = DockStyle.Bottom;
            panelCampos.Location = new Point(0, 437);
            panelCampos.Margin = new Padding(4, 5, 4, 5);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(546, 313);
            panelCampos.TabIndex = 4;
            // 
            // exitButton
            // 
            exitButton.Cursor = Cursors.Hand;
            exitButton.Location = new Point(313, 185);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(136, 53);
            exitButton.TabIndex = 7;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += opcionSalir_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Cursor = Cursors.Hand;
            registerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            registerLabel.ForeColor = Color.Snow;
            registerLabel.ImageAlign = ContentAlignment.BottomCenter;
            registerLabel.Location = new Point(22, 269);
            registerLabel.Margin = new Padding(4, 0, 4, 0);
            registerLabel.Name = "registerLabel";
            registerLabel.RightToLeft = RightToLeft.No;
            registerLabel.Size = new Size(259, 25);
            registerLabel.TabIndex = 6;
            registerLabel.Text = "¿No tenes cuenta? Registrate";
            registerLabel.Click += registerLabel_Click;
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Cursor = Cursors.Hand;
            botonIniciarSesion.Location = new Point(89, 185);
            botonIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(136, 53);
            botonIniciarSesion.TabIndex = 5;
            botonIniciarSesion.Text = "Iniciar";
            botonIniciarSesion.UseVisualStyleBackColor = true;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // contraseñaIniciarSesion
            // 
            contraseñaIniciarSesion.FlatAppearance.BorderSize = 0;
            contraseñaIniciarSesion.FlatStyle = FlatStyle.Flat;
            contraseñaIniciarSesion.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñaIniciarSesion.ForeColor = Color.White;
            contraseñaIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.Key;
            contraseñaIniciarSesion.IconColor = Color.White;
            contraseñaIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            contraseñaIniciarSesion.IconSize = 30;
            contraseñaIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            contraseñaIniciarSesion.Location = new Point(54, 88);
            contraseñaIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            contraseñaIniciarSesion.Name = "contraseñaIniciarSesion";
            contraseñaIniciarSesion.Size = new Size(170, 68);
            contraseñaIniciarSesion.TabIndex = 4;
            contraseñaIniciarSesion.Text = "Contraseña";
            contraseñaIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            contraseñaIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            contraseñaIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // nombreIniciarSesion
            // 
            nombreIniciarSesion.FlatAppearance.BorderSize = 0;
            nombreIniciarSesion.FlatStyle = FlatStyle.Flat;
            nombreIniciarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nombreIniciarSesion.ForeColor = Color.White;
            nombreIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            nombreIniciarSesion.IconColor = Color.White;
            nombreIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nombreIniciarSesion.IconSize = 30;
            nombreIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            nombreIniciarSesion.Location = new Point(54, 10);
            nombreIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            nombreIniciarSesion.Name = "nombreIniciarSesion";
            nombreIniciarSesion.Size = new Size(170, 68);
            nombreIniciarSesion.TabIndex = 0;
            nombreIniciarSesion.Text = "Usuario";
            nombreIniciarSesion.TextAlign = ContentAlignment.MiddleLeft;
            nombreIniciarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            nombreIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // panelIniciarSesion
            // 
            panelIniciarSesion.Controls.Add(tituloIniciarSesion);
            panelIniciarSesion.Dock = DockStyle.Fill;
            panelIniciarSesion.Location = new Point(0, 323);
            panelIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            panelIniciarSesion.Name = "panelIniciarSesion";
            panelIniciarSesion.Size = new Size(546, 114);
            panelIniciarSesion.TabIndex = 6;
            // 
            // tituloIniciarSesion
            // 
            tituloIniciarSesion.BackColor = Color.FromArgb(22, 160, 133);
            tituloIniciarSesion.Dock = DockStyle.Top;
            tituloIniciarSesion.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tituloIniciarSesion.ForeColor = Color.White;
            tituloIniciarSesion.Location = new Point(0, 0);
            tituloIniciarSesion.Margin = new Padding(4, 0, 4, 0);
            tituloIniciarSesion.Name = "tituloIniciarSesion";
            tituloIniciarSesion.Size = new Size(546, 108);
            tituloIniciarSesion.TabIndex = 0;
            tituloIniciarSesion.Text = "Inicie sesión";
            tituloIniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            tituloIniciarSesion.Click += tituloIniciarSesion_Click;
            // 
            // linkChangePass
            // 
            linkChangePass.AutoSize = true;
            linkChangePass.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkChangePass.LinkColor = Color.White;
            linkChangePass.Location = new Point(243, 143);
            linkChangePass.Name = "linkChangePass";
            linkChangePass.RightToLeft = RightToLeft.No;
            linkChangePass.Size = new Size(215, 25);
            linkChangePass.TabIndex = 8;
            linkChangePass.TabStop = true;
            linkChangePass.Text = "¿Olvidó su contraseña?";
            linkChangePass.LinkClicked += linkChangePass_LinkClicked;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(546, 750);
            Controls.Add(panelIniciarSesion);
            Controls.Add(panelCampos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconoChancho).EndInit();
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            panelIniciarSesion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox TxtPassword;
        private TextBox TxtUser;
        private Panel panel1;
        private PictureBox iconoChancho;
        private Panel panel3;
        private Panel panelCampos;
        private Panel panelIniciarSesion;
        private Label tituloIniciarSesion;
        private FontAwesome.Sharp.IconButton nombreIniciarSesion;
        private FontAwesome.Sharp.IconButton contraseñaIniciarSesion;
        private Button botonIniciarSesion;
        private Label registerLabel;
        private Button exitButton;
        private LinkLabel linkChangePass;
    }
}