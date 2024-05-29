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
            BtnPegarClipboard = new Button();
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
            labelIngresaDatos.Location = new Point(57, 121);
            labelIngresaDatos.Margin = new Padding(4, 0, 4, 0);
            labelIngresaDatos.Name = "labelIngresaDatos";
            labelIngresaDatos.Size = new Size(476, 32);
            labelIngresaDatos.TabIndex = 0;
            labelIngresaDatos.Text = "Ingresa alias o CBU de la cuenta a transferir";
            // 
            // TxtBoxDatosCuenta
            // 
            TxtBoxDatosCuenta.Location = new Point(57, 172);
            TxtBoxDatosCuenta.Margin = new Padding(4, 5, 4, 5);
            TxtBoxDatosCuenta.Name = "TxtBoxDatosCuenta";
            TxtBoxDatosCuenta.Size = new Size(378, 31);
            TxtBoxDatosCuenta.TabIndex = 1;
            // 
            // BtnPegarClipboard
            // 
            BtnPegarClipboard.Cursor = Cursors.Hand;
            BtnPegarClipboard.Location = new Point(456, 168);
            BtnPegarClipboard.Margin = new Padding(4, 5, 4, 5);
            BtnPegarClipboard.Name = "BtnPegarClipboard";
            BtnPegarClipboard.Size = new Size(128, 38);
            BtnPegarClipboard.TabIndex = 2;
            BtnPegarClipboard.Text = "Pegar";
            BtnPegarClipboard.UseVisualStyleBackColor = true;
            BtnPegarClipboard.Click += BtnPegarClipboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(57, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(358, 32);
            label1.TabIndex = 3;
            label1.Text = "Selecciona uno de tus contactos";
            // 
            // TablaContactos
            // 
            TablaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaContactos.Location = new Point(57, 275);
            TablaContactos.Margin = new Padding(4, 5, 4, 5);
            TablaContactos.Name = "TablaContactos";
            TablaContactos.ReadOnly = true;
            TablaContactos.RowHeadersWidth = 62;
            TablaContactos.RowTemplate.Height = 25;
            TablaContactos.Size = new Size(527, 353);
            TablaContactos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(283, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(649, 675);
            Controls.Add(pictureBox1);
            Controls.Add(TablaContactos);
            Controls.Add(label1);
            Controls.Add(BtnPegarClipboard);
            Controls.Add(TxtBoxDatosCuenta);
            Controls.Add(labelIngresaDatos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            ((System.ComponentModel.ISupportInitialize)TablaContactos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngresaDatos;
        private TextBox TxtBoxDatosCuenta;
        private Button BtnPegarClipboard;
        private Label label1;
        private DataGridView TablaContactos;
        private PictureBox pictureBox1;
    }
}