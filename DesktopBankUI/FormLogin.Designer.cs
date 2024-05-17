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
<<<<<<< Updated upstream
            groupBox1 = new GroupBox();
            TxtPassword = new TextBox();
            TxtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            BtnIniciar = new Button();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            TxtPassword = new TextBox();
            TxtUser = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            iconoChancho = new PictureBox();
            panelCampos = new Panel();
            btnRegistrarse = new LinkLabel();
            botonIniciarSesion = new Button();
            contraseñaIniciarSesion = new FontAwesome.Sharp.IconButton();
            nombreIniciarSesion = new FontAwesome.Sharp.IconButton();
            panelIniciarSesion = new Panel();
            tituloIniciarSesion = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconoChancho).BeginInit();
            panelCampos.SuspendLayout();
            panelIniciarSesion.SuspendLayout();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            TxtPassword.Location = new Point(98, 52);
=======
            TxtPassword.BackColor = Color.LightCyan;
            TxtPassword.Location = new Point(233, 123);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(244, 31);
            TxtPassword.TabIndex = 3;
            // 
            // TxtUser
            // 
<<<<<<< Updated upstream
            TxtUser.Location = new Point(98, 22);
=======
            TxtUser.BackColor = Color.LightCyan;
            TxtUser.Location = new Point(233, 45);
            TxtUser.Margin = new Padding(4, 5, 4, 5);
>>>>>>> Stashed changes
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(244, 31);
            TxtUser.TabIndex = 2;
            TxtUser.TextChanged += TxtUser_TextChanged;
            // 
            // label2
            // 
<<<<<<< Updated upstream
            label2.AutoSize = true;
            label2.Location = new Point(22, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
=======
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(iconoChancho);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 355);
            panel1.TabIndex = 3;
>>>>>>> Stashed changes
            // 
            // label1
            // 
<<<<<<< Updated upstream
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
=======
            panel3.Location = new Point(0, 348);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(550, 110);
            panel3.TabIndex = 6;
>>>>>>> Stashed changes
            // 
            // BtnIniciar
            // 
<<<<<<< Updated upstream
            BtnIniciar.Location = new Point(287, 189);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(75, 23);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
=======
            iconoChancho.BackColor = Color.Teal;
            iconoChancho.Image = (System.Drawing.Image)resources.GetObject("iconoChancho.Image");
            iconoChancho.Location = new Point(179, 50);
            iconoChancho.Margin = new Padding(4, 5, 4, 5);
            iconoChancho.Name = "iconoChancho";
            iconoChancho.Size = new Size(192, 198);
            iconoChancho.SizeMode = PictureBoxSizeMode.Zoom;
            iconoChancho.TabIndex = 0;
            iconoChancho.TabStop = false;
>>>>>>> Stashed changes
            // 
            // linkLabel1
            // 
<<<<<<< Updated upstream
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
=======
            panelCampos.BackColor = Color.LightSteelBlue;
            panelCampos.Controls.Add(btnRegistrarse);
            panelCampos.Controls.Add(botonIniciarSesion);
            panelCampos.Controls.Add(contraseñaIniciarSesion);
            panelCampos.Controls.Add(TxtPassword);
            panelCampos.Controls.Add(nombreIniciarSesion);
            panelCampos.Controls.Add(TxtUser);
            panelCampos.Dock = DockStyle.Bottom;
            panelCampos.Location = new Point(0, 424);
            panelCampos.Margin = new Padding(4, 5, 4, 5);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(546, 293);
            panelCampos.TabIndex = 4;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.AutoSize = true;
            btnRegistrarse.Location = new Point(153, 259);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(218, 25);
            btnRegistrarse.TabIndex = 7;
            btnRegistrarse.TabStop = true;
            btnRegistrarse.Text = "Cree su nueva cuenta aquí";
            btnRegistrarse.LinkClicked += btnRegistrarse_LinkClicked;
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Cursor = Cursors.Hand;
            botonIniciarSesion.Location = new Point(198, 187);
            botonIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(136, 53);
            botonIniciarSesion.TabIndex = 5;
            botonIniciarSesion.Text = "Ingresar";
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
            contraseñaIniciarSesion.Location = new Point(54, 105);
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
            nombreIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            nombreIniciarSesion.IconColor = Color.Black;
            nombreIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nombreIniciarSesion.IconSize = 30;
            nombreIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            nombreIniciarSesion.Location = new Point(54, 27);
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
            panelIniciarSesion.Location = new Point(0, 355);
            panelIniciarSesion.Margin = new Padding(4, 5, 4, 5);
            panelIniciarSesion.Name = "panelIniciarSesion";
            panelIniciarSesion.Size = new Size(546, 69);
            panelIniciarSesion.TabIndex = 6;
            // 
            // tituloIniciarSesion
            // 
            tituloIniciarSesion.BackColor = Color.RoyalBlue;
            tituloIniciarSesion.Dock = DockStyle.Fill;
            tituloIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tituloIniciarSesion.Location = new Point(0, 0);
            tituloIniciarSesion.Margin = new Padding(4, 0, 4, 0);
            tituloIniciarSesion.Name = "tituloIniciarSesion";
            tituloIniciarSesion.Size = new Size(546, 69);
            tituloIniciarSesion.TabIndex = 0;
            tituloIniciarSesion.Text = "Online Banking";
            tituloIniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
>>>>>>> Stashed changes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(450, 254);
            Controls.Add(linkLabel1);
            Controls.Add(BtnIniciar);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
=======
            BackColor = Color.White;
            ClientSize = new Size(546, 717);
            Controls.Add(panelIniciarSesion);
            Controls.Add(panelCampos);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogin";
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
        private Label label2;
        private Label label1;
        private Button BtnIniciar;
        private LinkLabel linkLabel1;
=======
        private Panel panel1;
        private PictureBox iconoChancho;
        private Panel panel3;
        private Panel panelCampos;
        private Panel panelIniciarSesion;
        private Label tituloIniciarSesion;
        private FontAwesome.Sharp.IconButton nombreIniciarSesion;
        private FontAwesome.Sharp.IconButton contraseñaIniciarSesion;
        private Button botonIniciarSesion;
        private LinkLabel btnRegistrarse;
>>>>>>> Stashed changes
    }
}