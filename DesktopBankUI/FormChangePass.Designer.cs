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
            txtMailChangePass = new TextBox();
            btnCancelarChP = new Button();
            etqUserChP = new Label();
            panel2 = new Panel();
            txtCode = new TextBox();
            btnAceptarCode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnEnviarCode
            // 
            btnEnviarCode.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarCode.ForeColor = Color.Black;
            btnEnviarCode.Location = new Point(245, 126);
            btnEnviarCode.Name = "btnEnviarCode";
            btnEnviarCode.Size = new Size(243, 53);
            btnEnviarCode.TabIndex = 0;
            btnEnviarCode.Text = "Enviar código";
            btnEnviarCode.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(txtMailChangePass);
            panel1.Controls.Add(etqUserChP);
            panel1.Controls.Add(btnEnviarCode);
            panel1.Location = new Point(51, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 199);
            panel1.TabIndex = 3;
            // 
            // txtMailChangePass
            // 
            txtMailChangePass.Location = new Point(106, 79);
            txtMailChangePass.Name = "txtMailChangePass";
            txtMailChangePass.Size = new Size(535, 31);
            txtMailChangePass.TabIndex = 4;
            // 
            // btnCancelarChP
            // 
            btnCancelarChP.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarChP.ForeColor = Color.Black;
            btnCancelarChP.Location = new Point(623, 554);
            btnCancelarChP.Name = "btnCancelarChP";
            btnCancelarChP.Size = new Size(166, 61);
            btnCancelarChP.TabIndex = 4;
            btnCancelarChP.Text = "Cancelar";
            btnCancelarChP.UseVisualStyleBackColor = true;
            btnCancelarChP.Click += btnCancelarChP_Click;
            // 
            // etqUserChP
            // 
            etqUserChP.AutoSize = true;
            etqUserChP.Font = new Font("Trebuchet MS", 20F, FontStyle.Regular, GraphicsUnit.Point);
            etqUserChP.Location = new Point(97, 17);
            etqUserChP.Name = "etqUserChP";
            etqUserChP.Size = new Size(544, 49);
            etqUserChP.TabIndex = 1;
            etqUserChP.Text = "Ingrese su correo electrónico";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAceptarCode);
            panel2.Controls.Add(txtCode);
            panel2.Controls.Add(etqInsertarCodigo);
            panel2.Location = new Point(51, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 219);
            panel2.TabIndex = 4;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(187, 84);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(344, 31);
            txtCode.TabIndex = 3;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.iconPig;
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(514, 554);
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
            ClientSize = new Size(822, 639);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelarChP);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "FormChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambiar contraseña";
            Load += FormChangePass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel2;
        private Button btnAceptarCode;
        private TextBox txtCode;
        private PictureBox pictureBox1;
    }
}