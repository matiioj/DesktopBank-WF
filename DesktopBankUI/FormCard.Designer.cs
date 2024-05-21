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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCard));
            gBoxTarjetaDeCredito = new GroupBox();
            BtnCopiar = new Button();
            EtqSaldoPesos = new Label();
            EtqCodigoSeguridad = new Label();
            EtqCvv = new Label();
            EtqFechaVencimiento = new Label();
            EtqTxtVencimiento = new Label();
            EtqTxtSaldo = new Label();
            EtqNombreUsuario = new Label();
            EtqTcNumber = new Label();
            gBoxTarjetaDeCredito.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxTarjetaDeCredito
            // 
            gBoxTarjetaDeCredito.BackgroundImage = (Image)resources.GetObject("gBoxTarjetaDeCredito.BackgroundImage");
            gBoxTarjetaDeCredito.BackgroundImageLayout = ImageLayout.Stretch;
            gBoxTarjetaDeCredito.Controls.Add(BtnCopiar);
            gBoxTarjetaDeCredito.Controls.Add(EtqSaldoPesos);
            gBoxTarjetaDeCredito.Controls.Add(EtqCodigoSeguridad);
            gBoxTarjetaDeCredito.Controls.Add(EtqCvv);
            gBoxTarjetaDeCredito.Controls.Add(EtqFechaVencimiento);
            gBoxTarjetaDeCredito.Controls.Add(EtqTxtVencimiento);
            gBoxTarjetaDeCredito.Controls.Add(EtqTxtSaldo);
            gBoxTarjetaDeCredito.Controls.Add(EtqNombreUsuario);
            gBoxTarjetaDeCredito.Controls.Add(EtqTcNumber);
            gBoxTarjetaDeCredito.Location = new Point(-2, -8);
            gBoxTarjetaDeCredito.Margin = new Padding(2);
            gBoxTarjetaDeCredito.Name = "gBoxTarjetaDeCredito";
            gBoxTarjetaDeCredito.Padding = new Padding(2);
            gBoxTarjetaDeCredito.Size = new Size(1182, 636);
            gBoxTarjetaDeCredito.TabIndex = 0;
            gBoxTarjetaDeCredito.TabStop = false;
            // 
            // BtnCopiar
            // 
            BtnCopiar.BackColor = SystemColors.Highlight;
            BtnCopiar.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiar.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCopiar.ForeColor = SystemColors.HighlightText;
            BtnCopiar.Location = new Point(573, 196);
            BtnCopiar.Margin = new Padding(2);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(160, 43);
            BtnCopiar.TabIndex = 8;
            BtnCopiar.Text = "COPIAR";
            BtnCopiar.UseVisualStyleBackColor = false;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // EtqSaldoPesos
            // 
            EtqSaldoPesos.AutoSize = true;
            EtqSaldoPesos.BackColor = SystemColors.Window;
            EtqSaldoPesos.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqSaldoPesos.ForeColor = Color.MidnightBlue;
            EtqSaldoPesos.Location = new Point(583, 371);
            EtqSaldoPesos.Margin = new Padding(2, 0, 2, 0);
            EtqSaldoPesos.Name = "EtqSaldoPesos";
            EtqSaldoPesos.Size = new Size(93, 49);
            EtqSaldoPesos.TabIndex = 7;
            EtqSaldoPesos.Text = "0.00";
            // 
            // EtqCodigoSeguridad
            // 
            EtqCodigoSeguridad.AutoSize = true;
            EtqCodigoSeguridad.BackColor = SystemColors.Window;
            EtqCodigoSeguridad.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCodigoSeguridad.ForeColor = Color.MidnightBlue;
            EtqCodigoSeguridad.Location = new Point(583, 565);
            EtqCodigoSeguridad.Margin = new Padding(2, 0, 2, 0);
            EtqCodigoSeguridad.Name = "EtqCodigoSeguridad";
            EtqCodigoSeguridad.Size = new Size(97, 49);
            EtqCodigoSeguridad.TabIndex = 6;
            EtqCodigoSeguridad.Text = "XXX";
            // 
            // EtqCvv
            // 
            EtqCvv.AutoSize = true;
            EtqCvv.BackColor = SystemColors.Window;
            EtqCvv.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCvv.ForeColor = Color.MidnightBlue;
            EtqCvv.Location = new Point(485, 565);
            EtqCvv.Margin = new Padding(2, 0, 2, 0);
            EtqCvv.Name = "EtqCvv";
            EtqCvv.Size = new Size(99, 49);
            EtqCvv.TabIndex = 5;
            EtqCvv.Text = "CVV:";
            // 
            // EtqFechaVencimiento
            // 
            EtqFechaVencimiento.AutoSize = true;
            EtqFechaVencimiento.BackColor = SystemColors.Window;
            EtqFechaVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqFechaVencimiento.ForeColor = Color.MidnightBlue;
            EtqFechaVencimiento.Location = new Point(282, 565);
            EtqFechaVencimiento.Margin = new Padding(2, 0, 2, 0);
            EtqFechaVencimiento.Name = "EtqFechaVencimiento";
            EtqFechaVencimiento.Size = new Size(139, 49);
            EtqFechaVencimiento.TabIndex = 4;
            EtqFechaVencimiento.Text = "XX/XX";
            // 
            // EtqTxtVencimiento
            // 
            EtqTxtVencimiento.AutoSize = true;
            EtqTxtVencimiento.BackColor = SystemColors.Window;
            EtqTxtVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTxtVencimiento.ForeColor = Color.MidnightBlue;
            EtqTxtVencimiento.Location = new Point(55, 565);
            EtqTxtVencimiento.Margin = new Padding(2, 0, 2, 0);
            EtqTxtVencimiento.Name = "EtqTxtVencimiento";
            EtqTxtVencimiento.Size = new Size(228, 49);
            EtqTxtVencimiento.TabIndex = 3;
            EtqTxtVencimiento.Text = "Vencimiento:";
            // 
            // EtqTxtSaldo
            // 
            EtqTxtSaldo.AutoSize = true;
            EtqTxtSaldo.BackColor = SystemColors.Window;
            EtqTxtSaldo.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTxtSaldo.ForeColor = Color.MidnightBlue;
            EtqTxtSaldo.Location = new Point(87, 382);
            EtqTxtSaldo.Margin = new Padding(2, 0, 2, 0);
            EtqTxtSaldo.Name = "EtqTxtSaldo";
            EtqTxtSaldo.Size = new Size(157, 49);
            EtqTxtSaldo.TabIndex = 2;
            EtqTxtSaldo.Text = "Saldo: $";
            // 
            // EtqNombreUsuario
            // 
            EtqNombreUsuario.AutoSize = true;
            EtqNombreUsuario.BackColor = SystemColors.Window;
            EtqNombreUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqNombreUsuario.ForeColor = Color.MidnightBlue;
            EtqNombreUsuario.Location = new Point(87, 299);
            EtqNombreUsuario.Margin = new Padding(2, 0, 2, 0);
            EtqNombreUsuario.Name = "EtqNombreUsuario";
            EtqNombreUsuario.Size = new Size(200, 49);
            EtqNombreUsuario.TabIndex = 1;
            EtqNombreUsuario.Text = "Propietario";
            // 
            // EtqTcNumber
            // 
            EtqTcNumber.AutoSize = true;
            EtqTcNumber.BackColor = SystemColors.Window;
            EtqTcNumber.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTcNumber.ForeColor = Color.MidnightBlue;
            EtqTcNumber.Location = new Point(87, 196);
            EtqTcNumber.Margin = new Padding(2, 0, 2, 0);
            EtqTcNumber.Name = "EtqTcNumber";
            EtqTcNumber.Size = new Size(452, 49);
            EtqTcNumber.TabIndex = 0;
            EtqTcNumber.Text = "XXXX XXXX XXXX XXXX";
            // 
            // FormCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            Controls.Add(gBoxTarjetaDeCredito);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormCard";
            Text = "FormCard";
            Load += FormCard_Load;
            gBoxTarjetaDeCredito.ResumeLayout(false);
            gBoxTarjetaDeCredito.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxTarjetaDeCredito;
        private Button BtnCopiar;
        private Label EtqSaldoPesos;
        private Label EtqCodigoSeguridad;
        private Label EtqCvv;
        private Label EtqFechaVencimiento;
        private Label EtqTxtVencimiento;
        private Label EtqTxtSaldo;
        private Label EtqNombreUsuario;
        private Label EtqTcNumber;
    }
}