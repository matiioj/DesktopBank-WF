namespace DesktopBankUI
{
    partial class FormTransferencia
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
            labelIngresaDatos = new Label();
            TxtBoxDatosCuenta = new TextBox();
            BtnTransfer = new Button();
            labelRecientes = new Label();
            pictureBox1 = new PictureBox();
            listaRecientes = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelIngresaDatos
            // 
            labelIngresaDatos.AutoSize = true;
            labelIngresaDatos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngresaDatos.ForeColor = SystemColors.ControlLightLight;
            labelIngresaDatos.Location = new Point(40, 73);
            labelIngresaDatos.Name = "labelIngresaDatos";
            labelIngresaDatos.Size = new Size(310, 21);
            labelIngresaDatos.TabIndex = 0;
            labelIngresaDatos.Text = "Ingresa alias o CBU de la cuenta a transferir";
            // 
            // TxtBoxDatosCuenta
            // 
            TxtBoxDatosCuenta.Location = new Point(40, 103);
            TxtBoxDatosCuenta.Name = "TxtBoxDatosCuenta";
            TxtBoxDatosCuenta.Size = new Size(266, 23);
            TxtBoxDatosCuenta.TabIndex = 1;
            // 
            // BtnTransfer
            // 
            BtnTransfer.Cursor = Cursors.Hand;
            BtnTransfer.Location = new Point(319, 101);
            BtnTransfer.Name = "BtnTransfer";
            BtnTransfer.Size = new Size(90, 23);
            BtnTransfer.TabIndex = 2;
            BtnTransfer.Text = "Transferir ";
            BtnTransfer.UseVisualStyleBackColor = true;
            BtnTransfer.Click += BtnTransfer_Click;
            // 
            // labelRecientes
            // 
            labelRecientes.AutoSize = true;
            labelRecientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRecientes.ForeColor = SystemColors.ControlLightLight;
            labelRecientes.Location = new Point(40, 137);
            labelRecientes.Name = "labelRecientes";
            labelRecientes.Size = new Size(245, 21);
            labelRecientes.TabIndex = 3;
            labelRecientes.Text = "Selecciona dentro de tus recientes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(198, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listaRecientes
            // 
            listaRecientes.FormattingEnabled = true;
            listaRecientes.ItemHeight = 15;
            listaRecientes.Location = new Point(40, 165);
            listaRecientes.Name = "listaRecientes";
            listaRecientes.Size = new Size(369, 229);
            listaRecientes.TabIndex = 6;
            listaRecientes.SelectedIndexChanged += ListaRecientes_SelectedIndexChanged;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(454, 405);
            Controls.Add(listaRecientes);
            Controls.Add(pictureBox1);
            Controls.Add(labelRecientes);
            Controls.Add(BtnTransfer);
            Controls.Add(TxtBoxDatosCuenta);
            Controls.Add(labelIngresaDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            Load += FormTransferencia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngresaDatos;
        private TextBox TxtBoxDatosCuenta;
        private Button BtnTransfer;
        private Label labelRecientes;
        private PictureBox pictureBox1;
        private ListBox listaRecientes;
    }
}