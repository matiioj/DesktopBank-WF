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
            EtqApellidoUsuario = new Label();
            BtnCopiar = new Button();
            EtqCodigoSeguridad = new Label();
            EtqCvv = new Label();
            EtqFechaVencimiento = new Label();
            EtqTxtVencimiento = new Label();
            EtqNombreUsuario = new Label();
            EtqTcNumber = new Label();
            gBoxTarjetaDeCredito.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxTarjetaDeCredito
            // 
            gBoxTarjetaDeCredito.BackgroundImage = (Image)resources.GetObject("gBoxTarjetaDeCredito.BackgroundImage");
            gBoxTarjetaDeCredito.BackgroundImageLayout = ImageLayout.Stretch;
            gBoxTarjetaDeCredito.Controls.Add(EtqApellidoUsuario);
            gBoxTarjetaDeCredito.Controls.Add(BtnCopiar);
            gBoxTarjetaDeCredito.Controls.Add(EtqCodigoSeguridad);
            gBoxTarjetaDeCredito.Controls.Add(EtqCvv);
            gBoxTarjetaDeCredito.Controls.Add(EtqFechaVencimiento);
            gBoxTarjetaDeCredito.Controls.Add(EtqTxtVencimiento);
            gBoxTarjetaDeCredito.Controls.Add(EtqNombreUsuario);
            gBoxTarjetaDeCredito.Controls.Add(EtqTcNumber);
            gBoxTarjetaDeCredito.Location = new Point(-20, -15);
            gBoxTarjetaDeCredito.Name = "gBoxTarjetaDeCredito";
            gBoxTarjetaDeCredito.Size = new Size(1643, 1061);
            gBoxTarjetaDeCredito.TabIndex = 0;
            gBoxTarjetaDeCredito.TabStop = false;
            gBoxTarjetaDeCredito.Enter += gBoxTarjetaDeCredito_Enter;
            // 
            // EtqApellidoUsuario
            // 
            EtqApellidoUsuario.AutoSize = true;
            EtqApellidoUsuario.BackColor = SystemColors.Window;
            EtqApellidoUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqApellidoUsuario.ForeColor = Color.MidnightBlue;
            EtqApellidoUsuario.Location = new Point(368, 488);
            EtqApellidoUsuario.Name = "EtqApellidoUsuario";
            EtqApellidoUsuario.Size = new Size(227, 73);
            EtqApellidoUsuario.TabIndex = 9;
            EtqApellidoUsuario.Text = "Apellido";
            EtqApellidoUsuario.Click += EtqApellidoUsuario_Click;
            // 
            // BtnCopiar
            // 
            BtnCopiar.BackColor = SystemColors.Highlight;
            BtnCopiar.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiar.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCopiar.ForeColor = SystemColors.HighlightText;
            BtnCopiar.Location = new Point(658, 334);
            BtnCopiar.Name = "BtnCopiar";
            BtnCopiar.Size = new Size(229, 72);
            BtnCopiar.TabIndex = 8;
            BtnCopiar.Text = "COPIAR";
            BtnCopiar.UseVisualStyleBackColor = false;
            BtnCopiar.Click += BtnCopiar_Click;
            // 
            // EtqCodigoSeguridad
            // 
            EtqCodigoSeguridad.AutoSize = true;
            EtqCodigoSeguridad.BackColor = SystemColors.Window;
            EtqCodigoSeguridad.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqCodigoSeguridad.ForeColor = Color.MidnightBlue;
            EtqCodigoSeguridad.Location = new Point(801, 670);
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
            EtqCvv.Location = new Point(658, 670);
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
            EtqFechaVencimiento.Location = new Point(384, 670);
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
            EtqTxtVencimiento.Location = new Point(60, 670);
            EtqTxtVencimiento.Name = "EtqTxtVencimiento";
            EtqTxtVencimiento.Size = new Size(341, 73);
            EtqTxtVencimiento.TabIndex = 3;
            EtqTxtVencimiento.Text = "Vencimiento:";
            // 
            // EtqNombreUsuario
            // 
            EtqNombreUsuario.AutoSize = true;
            EtqNombreUsuario.BackColor = SystemColors.Window;
            EtqNombreUsuario.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqNombreUsuario.ForeColor = Color.MidnightBlue;
            EtqNombreUsuario.Location = new Point(60, 488);
            EtqNombreUsuario.Name = "EtqNombreUsuario";
            EtqNombreUsuario.Size = new Size(224, 73);
            EtqNombreUsuario.TabIndex = 1;
            EtqNombreUsuario.Text = "Nombre";
            // 
            // EtqTcNumber
            // 
            EtqTcNumber.AutoSize = true;
            EtqTcNumber.BackColor = SystemColors.Window;
            EtqTcNumber.Font = new Font("Comic Sans MS", 26F, FontStyle.Regular, GraphicsUnit.Point);
            EtqTcNumber.ForeColor = Color.MidnightBlue;
            EtqTcNumber.Location = new Point(60, 333);
            EtqTcNumber.Name = "EtqTcNumber";
            EtqTcNumber.Size = new Size(688, 73);
            EtqTcNumber.TabIndex = 0;
            EtqTcNumber.Text = "XXXX XXXX XXXX XXXX";
            EtqTcNumber.Click += EtqTcNumber_Click;
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
            gBoxTarjetaDeCredito.PerformLayout();
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
    }
}