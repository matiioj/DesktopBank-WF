namespace DesktopBankUI
{
    partial class FormChangePass
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
            btnEnviarCode = new Button();
            etqInsertarCodigo = new Label();
            panel1 = new Panel();
            panelNewPass = new Panel();
            btnChangePassConfirm = new Button();
            txtPassSecondValidation = new TextBox();
            txtPassFirstValidation = new TextBox();
            etqPassSecondValidation = new Label();
            etqPassFirstValidation = new Label();
            txtMailChangePass = new TextBox();
            etqUserChP = new Label();
            panelCode = new Panel();
            btnAceptarCode = new Button();
            txtCode = new TextBox();
            btnCancelarChP = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelNewPass.SuspendLayout();
            panelCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarCode
            // 
            btnEnviarCode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarCode.ForeColor = Color.Black;
            btnEnviarCode.Location = new Point(344, 146);
            btnEnviarCode.Name = "btnEnviarCode";
            btnEnviarCode.Size = new Size(243, 53);
            btnEnviarCode.TabIndex = 0;
            btnEnviarCode.Text = "Enviar código";
            btnEnviarCode.UseVisualStyleBackColor = true;
            btnEnviarCode.Click += btnEnviarCode_Click;
            // 
            // etqInsertarCodigo
            // 
            etqInsertarCodigo.AutoSize = true;
            etqInsertarCodigo.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            etqInsertarCodigo.Location = new Point(209, 12);
            etqInsertarCodigo.Name = "etqInsertarCodigo";
            etqInsertarCodigo.Size = new Size(293, 49);
            etqInsertarCodigo.TabIndex = 2;
            etqInsertarCodigo.Text = "Ingresar código";
            // 
            // panel1
            // 
            panel1.Controls.Add(panelNewPass);
            panel1.Controls.Add(txtMailChangePass);
            panel1.Controls.Add(etqUserChP);
            panel1.Controls.Add(panelCode);
            panel1.Controls.Add(btnEnviarCode);
            panel1.Location = new Point(40, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 579);
            panel1.TabIndex = 3;
            // 
            // panelNewPass
            // 
            panelNewPass.Controls.Add(btnChangePassConfirm);
            panelNewPass.Controls.Add(txtPassSecondValidation);
            panelNewPass.Controls.Add(txtPassFirstValidation);
            panelNewPass.Controls.Add(etqPassSecondValidation);
            panelNewPass.Controls.Add(etqPassFirstValidation);
            panelNewPass.Location = new Point(58, 17);
            panelNewPass.Name = "panelNewPass";
            panelNewPass.Size = new Size(812, 535);
            panelNewPass.TabIndex = 6;
            panelNewPass.Visible = false;
            // 
            // btnChangePassConfirm
            // 
            btnChangePassConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassConfirm.ForeColor = Color.Black;
            btnChangePassConfirm.Location = new Point(314, 375);
            btnChangePassConfirm.Name = "btnChangePassConfirm";
            btnChangePassConfirm.Size = new Size(199, 59);
            btnChangePassConfirm.TabIndex = 4;
            btnChangePassConfirm.Text = "Confirmar";
            btnChangePassConfirm.UseVisualStyleBackColor = true;
            btnChangePassConfirm.Click += btnChangePassConfirm_Click;
            // 
            // txtPassSecondValidation
            // 
            txtPassSecondValidation.Location = new Point(227, 280);
            txtPassSecondValidation.Name = "txtPassSecondValidation";
            txtPassSecondValidation.Size = new Size(367, 31);
            txtPassSecondValidation.TabIndex = 3;
            // 
            // txtPassFirstValidation
            // 
            txtPassFirstValidation.Location = new Point(227, 111);
            txtPassFirstValidation.Name = "txtPassFirstValidation";
            txtPassFirstValidation.Size = new Size(367, 31);
            txtPassFirstValidation.TabIndex = 2;
            // 
            // etqPassSecondValidation
            // 
            etqPassSecondValidation.AutoSize = true;
            etqPassSecondValidation.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            etqPassSecondValidation.Location = new Point(96, 194);
            etqPassSecondValidation.Name = "etqPassSecondValidation";
            etqPassSecondValidation.Size = new Size(659, 49);
            etqPassSecondValidation.TabIndex = 1;
            etqPassSecondValidation.Text = "Ingrese nuevamente su contraseña:";
            // 
            // etqPassFirstValidation
            // 
            etqPassFirstValidation.AutoSize = true;
            etqPassFirstValidation.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            etqPassFirstValidation.Location = new Point(237, 29);
            etqPassFirstValidation.Name = "etqPassFirstValidation";
            etqPassFirstValidation.Size = new Size(357, 49);
            etqPassFirstValidation.TabIndex = 0;
            etqPassFirstValidation.Text = "Contraseña nueva:";
            // 
            // txtMailChangePass
            // 
            txtMailChangePass.Location = new Point(205, 99);
            txtMailChangePass.Name = "txtMailChangePass";
            txtMailChangePass.Size = new Size(535, 31);
            txtMailChangePass.TabIndex = 4;
            txtMailChangePass.TextChanged += txtMailChangePass_TextChanged;
            // 
            // etqUserChP
            // 
            etqUserChP.AutoSize = true;
            etqUserChP.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            etqUserChP.Location = new Point(196, 37);
            etqUserChP.Name = "etqUserChP";
            etqUserChP.Size = new Size(544, 49);
            etqUserChP.TabIndex = 1;
            etqUserChP.Text = "Ingrese su correo electrónico";
            // 
            // panelCode
            // 
            panelCode.Controls.Add(btnAceptarCode);
            panelCode.Controls.Add(txtCode);
            panelCode.Controls.Add(etqInsertarCodigo);
            panelCode.Location = new Point(99, 262);
            panelCode.Name = "panelCode";
            panelCode.Size = new Size(738, 219);
            panelCode.TabIndex = 4;
            panelCode.Visible = false;
            // 
            // btnAceptarCode
            // 
            btnAceptarCode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarCode.ForeColor = Color.Black;
            btnAceptarCode.Location = new Point(277, 140);
            btnAceptarCode.Name = "btnAceptarCode";
            btnAceptarCode.Size = new Size(166, 57);
            btnAceptarCode.TabIndex = 4;
            btnAceptarCode.Text = "Aceptar";
            btnAceptarCode.UseVisualStyleBackColor = true;
            btnAceptarCode.Click += btnAceptarCode_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(187, 84);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(344, 31);
            txtCode.TabIndex = 3;
            // 
            // btnCancelarChP
            // 
            btnCancelarChP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarChP.ForeColor = Color.Black;
            btnCancelarChP.Location = new Point(804, 655);
            btnCancelarChP.Name = "btnCancelarChP";
            btnCancelarChP.Size = new Size(166, 61);
            btnCancelarChP.TabIndex = 4;
            btnCancelarChP.Text = "Cancelar";
            btnCancelarChP.UseVisualStyleBackColor = true;
            btnCancelarChP.Click += btnCancelarChP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.iconPig;
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(720, 655);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormChangePass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(984, 728);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelarChP);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "FormChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar contraseña";
            Load += FormChangePass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelNewPass.ResumeLayout(false);
            panelNewPass.PerformLayout();
            panelCode.ResumeLayout(false);
            panelCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEnviarCode;
        private Label etqInsertarCodigo;
        private Panel panel1;
        private TextBox txtMailChangePass;
        private Button btnCancelarChP;
        private Label etqUserChP;
        private Panel panelCode;
        private Button btnAceptarCode;
        private TextBox txtCode;
        private PictureBox pictureBox1;
        private Panel panelNewPass;
        private Label etqPassFirstValidation;
        private TextBox txtPassSecondValidation;
        private TextBox txtPassFirstValidation;
        private Label etqPassSecondValidation;
        private Button btnChangePassConfirm;
    }
}