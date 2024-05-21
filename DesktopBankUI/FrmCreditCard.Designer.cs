namespace DesktopBankUI
{
    partial class FrmCreditCard
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
            gBoxTarjetaDeCredito.BackgroundImage = Properties.Resources.Istic_Wallet_Credit_Card;
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
            gBoxTarjetaDeCredito.Location = new Point(-3, -13);
            gBoxTarjetaDeCredito.Name = "gBoxTarjetaDeCredito";
            gBoxTarjetaDeCredito.Size = new Size(1688, 1060);
            gBoxTarjetaDeCredito.TabIndex = 0;
            gBoxTarjetaDeCredito.TabStop = false;
            // 
            // BtnCopiar
            // 
            BtnCopiar.BackColor = SystemColors.Highlight;
            BtnCopiar.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiar.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCopiar.ForeColor = SystemColors.HighlightText;
            BtnCopiar.Location = new Point(818, 326);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(228, 71);
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
            EtqSaldoPesos.Location = new Point(833, 618);
            EtqSaldoPesos.Name = "EtqSaldoPesos";
            EtqSaldoPesos.Size = new Size(141, 73);
            EtqSaldoPesos.TabIndex = 7;
            EtqSaldoPesos.Text = "0.00";
            // 
            // EtqCodigoSeguridad
            // 
            EtqCodigoSeguridad.AutoSize = true;
            EtqCodigoSeguridad.BackColor = SystemColors.Window;
            EtqCodigoSeguridad.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCodigoSeguridad.ForeColor = Color.MidnightBlue;
            EtqCodigoSeguridad.Location = new Point(833, 942);
            EtqCodigoSeguridad.Name = "EtqCodigoSeguridad";
            EtqCodigoSeguridad.Size = new Size(146, 73);
            EtqCodigoSeguridad.TabIndex = 6;
            EtqCodigoSeguridad.Text = "XXX";
            // 
            // EtqCvv
            // 
            EtqCvv.AutoSize = true;
            EtqCvv.BackColor = SystemColors.Window;
            EtqCvv.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCvv.ForeColor = Color.MidnightBlue;
            EtqCvv.Location = new Point(693, 942);
            EtqCvv.Name = "EtqCvv";
            EtqCvv.Size = new Size(147, 73);
            EtqCvv.TabIndex = 5;
            EtqCvv.Text = "CVV:";
            // 
            // EtqFechaVencimiento
            // 
            EtqFechaVencimiento.AutoSize = true;
            EtqFechaVencimiento.BackColor = SystemColors.Window;
            EtqFechaVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqFechaVencimiento.ForeColor = Color.MidnightBlue;
            EtqFechaVencimiento.Location = new Point(403, 942);
            EtqFechaVencimiento.Name = "EtqFechaVencimiento";
            EtqFechaVencimiento.Size = new Size(211, 73);
            EtqFechaVencimiento.TabIndex = 4;
            EtqFechaVencimiento.Text = "XX/XX";
            // 
            // EtqTxtVencimiento
            // 
            EtqTxtVencimiento.AutoSize = true;
            EtqTxtVencimiento.BackColor = SystemColors.Window;
            EtqTxtVencimiento.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTxtVencimiento.ForeColor = Color.MidnightBlue;
            EtqTxtVencimiento.Location = new Point(79, 942);
            EtqTxtVencimiento.Name = "EtqTxtVencimiento";
            EtqTxtVencimiento.Size = new Size(341, 73);
            EtqTxtVencimiento.TabIndex = 3;
            EtqTxtVencimiento.Text = "Vencimiento:";
            // 
            // EtqTxtSaldo
            // 
            EtqTxtSaldo.AutoSize = true;
            EtqTxtSaldo.BackColor = SystemColors.Window;
            EtqTxtSaldo.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTxtSaldo.ForeColor = Color.MidnightBlue;
            EtqTxtSaldo.Location = new Point(124, 637);
            EtqTxtSaldo.Name = "EtqTxtSaldo";
            EtqTxtSaldo.Size = new Size(235, 73);
            EtqTxtSaldo.TabIndex = 2;
            EtqTxtSaldo.Text = "Saldo: $";
            // 
            // EtqNombreUsuario
            // 
            EtqNombreUsuario.AutoSize = true;
            EtqNombreUsuario.BackColor = SystemColors.Window;
            EtqNombreUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqNombreUsuario.ForeColor = Color.MidnightBlue;
            EtqNombreUsuario.Location = new Point(124, 498);
            EtqNombreUsuario.Name = "EtqNombreUsuario";
            EtqNombreUsuario.Size = new Size(301, 73);
            EtqNombreUsuario.TabIndex = 1;
            EtqNombreUsuario.Text = "Propietario";
            // 
            // EtqTcNumber
            // 
            EtqTcNumber.AutoSize = true;
            EtqTcNumber.BackColor = SystemColors.Window;
            EtqTcNumber.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTcNumber.ForeColor = Color.MidnightBlue;
            EtqTcNumber.Location = new Point(124, 326);
            EtqTcNumber.Name = "EtqTcNumber";
            EtqTcNumber.Size = new Size(688, 73);
            EtqTcNumber.TabIndex = 0;
            EtqTcNumber.Text = "XXXX XXXX XXXX XXXX";
            // 
            // FrmCreditCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 1047);
            Controls.Add(gBoxTarjetaDeCredito);
            DoubleBuffered = true;
            Name = "FrmCreditCard";
            Text = "FrmCreditCard";
            Load += FrmCreditCard_Load;
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