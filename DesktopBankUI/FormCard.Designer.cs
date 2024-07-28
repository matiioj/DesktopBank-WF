namespace DesktopBankUI
{
    partial class FormCard
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
            gBoxTarjetaDeCredito = new GroupBox();
            groupBox1 = new GroupBox();
            picBoxTc = new PictureBox();
            EtqTcNumber = new Label();
            EtqApellidoUsuario = new Label();
            EtqNombreUsuario = new Label();
            BtnCopiar = new Button();
            EtqTxtVencimiento = new Label();
            EtqCodigoSeguridad = new Label();
            EtqFechaVencimiento = new Label();
            EtqCvv = new Label();
            gBoxTarjetaDeCredito.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxTc).BeginInit();
            SuspendLayout();
            // 
            // gBoxTarjetaDeCredito
            // 
            gBoxTarjetaDeCredito.BackgroundImageLayout = ImageLayout.Stretch;
            gBoxTarjetaDeCredito.Controls.Add(groupBox1);
            gBoxTarjetaDeCredito.Location = new Point(-20, -15);
            gBoxTarjetaDeCredito.Name = "gBoxTarjetaDeCredito";
            gBoxTarjetaDeCredito.Size = new Size(1643, 1061);
            gBoxTarjetaDeCredito.TabIndex = 0;
            gBoxTarjetaDeCredito.TabStop = false;
            gBoxTarjetaDeCredito.Enter += gBoxTarjetaDeCredito_Enter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(22, 160, 133);
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(picBoxTc);
            groupBox1.Controls.Add(EtqTcNumber);
            groupBox1.Controls.Add(EtqApellidoUsuario);
            groupBox1.Controls.Add(EtqNombreUsuario);
            groupBox1.Controls.Add(BtnCopiar);
            groupBox1.Controls.Add(EtqTxtVencimiento);
            groupBox1.Controls.Add(EtqCodigoSeguridad);
            groupBox1.Controls.Add(EtqFechaVencimiento);
            groupBox1.Controls.Add(EtqCvv);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(93, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(957, 571);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tú tarjeta";
            // 
            // picBoxTc
            // 
            picBoxTc.Image = Properties.Resources.visadebit;
            picBoxTc.Location = new Point(721, 257);
            picBoxTc.Name = "picBoxTc";
            picBoxTc.Size = new Size(140, 143);
            picBoxTc.SizeMode = PictureBoxSizeMode.Zoom;
            picBoxTc.TabIndex = 10;
            picBoxTc.TabStop = false;
            picBoxTc.Click += picBoxTc_Click;
            // 
            // EtqTcNumber
            // 
            EtqTcNumber.AutoSize = true;
            EtqTcNumber.BackColor = Color.FromArgb(22, 160, 133);
            EtqTcNumber.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTcNumber.ForeColor = SystemColors.ButtonHighlight;
            EtqTcNumber.Location = new Point(34, 135);
            EtqTcNumber.Name = "EtqTcNumber";
            EtqTcNumber.Size = new Size(688, 73);
            EtqTcNumber.TabIndex = 0;
            EtqTcNumber.Text = "XXXX XXXX XXXX XXXX";
            EtqTcNumber.Click += EtqTcNumber_Click;
            // 
            // EtqApellidoUsuario
            // 
            EtqApellidoUsuario.AutoSize = true;
            EtqApellidoUsuario.BackColor = Color.FromArgb(22, 160, 133);
            EtqApellidoUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqApellidoUsuario.ForeColor = SystemColors.ButtonHighlight;
            EtqApellidoUsuario.Location = new Point(342, 290);
            EtqApellidoUsuario.Name = "EtqApellidoUsuario";
            EtqApellidoUsuario.Size = new Size(227, 73);
            EtqApellidoUsuario.TabIndex = 9;
            EtqApellidoUsuario.Text = "Apellido";
            EtqApellidoUsuario.Click += EtqApellidoUsuario_Click;
            // 
            // EtqNombreUsuario
            // 
            EtqNombreUsuario.AutoSize = true;
            EtqNombreUsuario.BackColor = Color.FromArgb(22, 160, 133);
            EtqNombreUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqNombreUsuario.ForeColor = SystemColors.ButtonHighlight;
            EtqNombreUsuario.Location = new Point(34, 290);
            EtqNombreUsuario.Name = "EtqNombreUsuario";
            EtqNombreUsuario.Size = new Size(224, 73);
            EtqNombreUsuario.TabIndex = 1;
            EtqNombreUsuario.Text = "Nombre";
            // 
            // BtnCopiar
            // 
            BtnCopiar.BackColor = SystemColors.ButtonHighlight;
            BtnCopiar.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiar.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCopiar.ForeColor = Color.FromArgb(22, 160, 133);
            BtnCopiar.Location = new Point(632, 136);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(229, 72);
            BtnCopiar.TabIndex = 8;
            BtnCopiar.Text = "COPIAR";
            BtnCopiar.UseVisualStyleBackColor = false;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // EtqTxtVencimiento
            // 
            EtqTxtVencimiento.AutoSize = true;
            EtqTxtVencimiento.BackColor = Color.FromArgb(22, 160, 133);
            EtqTxtVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTxtVencimiento.ForeColor = SystemColors.ButtonHighlight;
            EtqTxtVencimiento.Location = new Point(34, 472);
            EtqTxtVencimiento.Name = "EtqTxtVencimiento";
            EtqTxtVencimiento.Size = new Size(341, 73);
            EtqTxtVencimiento.TabIndex = 3;
            EtqTxtVencimiento.Text = "Vencimiento:";
            // 
            // EtqCodigoSeguridad
            // 
            EtqCodigoSeguridad.AutoSize = true;
            EtqCodigoSeguridad.BackColor = Color.FromArgb(22, 160, 133);
            EtqCodigoSeguridad.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCodigoSeguridad.ForeColor = SystemColors.ButtonHighlight;
            EtqCodigoSeguridad.Location = new Point(775, 472);
            EtqCodigoSeguridad.Name = "EtqCodigoSeguridad";
            EtqCodigoSeguridad.Size = new Size(146, 73);
            EtqCodigoSeguridad.TabIndex = 6;
            EtqCodigoSeguridad.Text = "XXX";
            // 
            // EtqFechaVencimiento
            // 
            EtqFechaVencimiento.AutoSize = true;
            EtqFechaVencimiento.BackColor = Color.FromArgb(22, 160, 133);
            EtqFechaVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqFechaVencimiento.ForeColor = SystemColors.ButtonHighlight;
            EtqFechaVencimiento.Location = new Point(358, 472);
            EtqFechaVencimiento.Name = "EtqFechaVencimiento";
            EtqFechaVencimiento.Size = new Size(211, 73);
            EtqFechaVencimiento.TabIndex = 4;
            EtqFechaVencimiento.Text = "XX/XX";
            // 
            // EtqCvv
            // 
            EtqCvv.AutoSize = true;
            EtqCvv.BackColor = Color.FromArgb(22, 160, 133);
            EtqCvv.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCvv.ForeColor = SystemColors.ButtonHighlight;
            EtqCvv.Location = new Point(632, 472);
            EtqCvv.Name = "EtqCvv";
            EtqCvv.Size = new Size(147, 73);
            EtqCvv.TabIndex = 5;
            EtqCvv.Text = "CVV:";
            // 
            // FormCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 1018);
            Controls.Add(gBoxTarjetaDeCredito);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCard";
            Text = "FormCard";
            Load += FormCard_Load;
            gBoxTarjetaDeCredito.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxTc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxTarjetaDeCredito;
        private Button BtnCopiar;
        private Label EtqCodigoSeguridad;
        private Label EtqCvv;
        private Label EtqFechaVencimiento;
        private Label EtqTxtVencimiento;
        private Label EtqNombreUsuario;
        private Label EtqTcNumber;
        private Label EtqApellidoUsuario;
        private GroupBox groupBox1;
        private PictureBox picBoxTc;
    }
}