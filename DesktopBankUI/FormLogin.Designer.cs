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
            opcionSalir = new Label();
            botonIniciarSesion = new Button();
            contraseñaIniciarSesion = new FontAwesome.Sharp.IconButton();
            nombreIniciarSesion = new FontAwesome.Sharp.IconButton();
            panelIniciarSesion = new Panel();
            tituloIniciarSesion = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoChancho).BeginInit();
            panelCampos.SuspendLayout();
            panelIniciarSesion.SuspendLayout();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.LightCyan;
            TxtPassword.Location = new Point(163, 74);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(172, 23);
            TxtPassword.TabIndex = 3;
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.LightCyan;
            TxtUser.Location = new Point(163, 27);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(172, 23);
            TxtUser.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(iconoChancho);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 213);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(385, 66);
            panel3.TabIndex = 6;
            // 
            // iconoChancho
            // 
            iconoChancho.BackColor = Color.Teal;
            iconoChancho.Image = Properties.Resources.iconPig;
            iconoChancho.Location = new Point(107, 31);
            iconoChancho.Name = "iconoChancho";
            iconoChancho.Size = new Size(174, 154);
            iconoChancho.SizeMode = PictureBoxSizeMode.Zoom;
            iconoChancho.TabIndex = 0;
            iconoChancho.TabStop = false;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.Teal;
            panelCampos.Controls.Add(opcionSalir);
            panelCampos.Controls.Add(botonIniciarSesion);
            panelCampos.Controls.Add(contraseñaIniciarSesion);
            panelCampos.Controls.Add(TxtPassword);
            panelCampos.Controls.Add(nombreIniciarSesion);
            panelCampos.Controls.Add(TxtUser);
            panelCampos.Dock = DockStyle.Bottom;
            panelCampos.Location = new Point(0, 254);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(382, 176);
            panelCampos.TabIndex = 4;
            // 
            // opcionSalir
            // 
            opcionSalir.Cursor = Cursors.Hand;
            opcionSalir.ImageAlign = ContentAlignment.BottomCenter;
            opcionSalir.Location = new Point(160, 150);
            opcionSalir.Name = "opcionSalir";
            opcionSalir.RightToLeft = RightToLeft.No;
            opcionSalir.Size = new Size(63, 22);
            opcionSalir.TabIndex = 6;
            opcionSalir.Text = "Registrate";
            opcionSalir.Click += opcionSalir_Click;
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Cursor = Cursors.Hand;
            botonIniciarSesion.Location = new Point(145, 112);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(95, 32);
            botonIniciarSesion.TabIndex = 5;
            botonIniciarSesion.Text = "Iniciar";
            botonIniciarSesion.UseVisualStyleBackColor = true;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // contraseñaIniciarSesion
            // 
            contraseñaIniciarSesion.FlatAppearance.BorderSize = 0;
            contraseñaIniciarSesion.FlatStyle = FlatStyle.Flat;
            contraseñaIniciarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            contraseñaIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.Key;
            contraseñaIniciarSesion.IconColor = Color.Black;
            contraseñaIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            contraseñaIniciarSesion.IconSize = 30;
            contraseñaIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            contraseñaIniciarSesion.Location = new Point(38, 63);
            contraseñaIniciarSesion.Name = "contraseñaIniciarSesion";
            contraseñaIniciarSesion.Size = new Size(119, 41);
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
            nombreIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            nombreIniciarSesion.IconColor = Color.Black;
            nombreIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nombreIniciarSesion.IconSize = 30;
            nombreIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            nombreIniciarSesion.Location = new Point(38, 16);
            nombreIniciarSesion.Name = "nombreIniciarSesion";
            nombreIniciarSesion.Size = new Size(119, 41);
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
            panelIniciarSesion.Location = new Point(0, 213);
            panelIniciarSesion.Name = "panelIniciarSesion";
            panelIniciarSesion.Size = new Size(382, 41);
            panelIniciarSesion.TabIndex = 6;
            // 
            // tituloIniciarSesion
            // 
            tituloIniciarSesion.BackColor = Color.PaleTurquoise;
            tituloIniciarSesion.Dock = DockStyle.Fill;
            tituloIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tituloIniciarSesion.Location = new Point(0, 0);
            tituloIniciarSesion.Name = "tituloIniciarSesion";
            tituloIniciarSesion.Size = new Size(382, 41);
            tituloIniciarSesion.TabIndex = 0;
            tituloIniciarSesion.Text = "Inicie sesión";
            tituloIniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 430);
            Controls.Add(panelIniciarSesion);
            Controls.Add(panelCampos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label opcionSalir;
    }
}