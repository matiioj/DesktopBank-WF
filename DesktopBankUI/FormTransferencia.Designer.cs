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
            label1 = new Label();
            TablaContactos = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TablaContactos).BeginInit();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(40, 137);
            label1.Name = "label1";
            label1.Size = new Size(230, 21);
            label1.TabIndex = 3;
            label1.Text = "Selecciona uno de tus contactos";
            // 
            // TablaContactos
            // 
            TablaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaContactos.Location = new Point(40, 165);
            TablaContactos.Name = "TablaContactos";
            TablaContactos.ReadOnly = true;
            TablaContactos.RowHeadersWidth = 62;
            TablaContactos.RowTemplate.Height = 25;
            TablaContactos.Size = new Size(369, 212);
            TablaContactos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(198, 13);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(454, 405);
            Controls.Add(pictureBox1);
            Controls.Add(TablaContactos);
            Controls.Add(label1);
            Controls.Add(BtnTransfer);
            Controls.Add(TxtBoxDatosCuenta);
            Controls.Add(labelIngresaDatos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            Load += FormTransferencia_Load;
            ((System.ComponentModel.ISupportInitialize)TablaContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngresaDatos;
        private TextBox TxtBoxDatosCuenta;
        private Button BtnTransfer;
        private Label label1;
        private DataGridView TablaContactos;
        private PictureBox pictureBox1;
    }
}