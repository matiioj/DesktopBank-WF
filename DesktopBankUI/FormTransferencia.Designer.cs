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
            botonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)TablaContactos).BeginInit();
            SuspendLayout();
            // 
            // labelIngresaDatos
            // 
            labelIngresaDatos.AutoSize = true;
            labelIngresaDatos.Location = new Point(39, 36);
            labelIngresaDatos.Name = "labelIngresaDatos";
            labelIngresaDatos.Size = new Size(162, 15);
            labelIngresaDatos.TabIndex = 0;
            labelIngresaDatos.Text = "Ingresa los datos de la cuenta";
            // 
            // TxtBoxDatosCuenta
            // 
            TxtBoxDatosCuenta.Location = new Point(39, 64);
            TxtBoxDatosCuenta.Name = "TxtBoxDatosCuenta";
            TxtBoxDatosCuenta.Size = new Size(370, 23);
            TxtBoxDatosCuenta.TabIndex = 1;
            // 
            // BtnPegarClipboard
            // 
            BtnPegarClipboard.Cursor = Cursors.Hand;
            BtnPegarClipboard.Location = new Point(40, 96);
            BtnPegarClipboard.Name = "BtnPegarClipboard";
            BtnPegarClipboard.Size = new Size(75, 23);
            BtnPegarClipboard.TabIndex = 2;
            BtnPegarClipboard.Text = "Pegar";
            BtnPegarClipboard.UseVisualStyleBackColor = true;
            BtnPegarClipboard.Click += BtnPegarClipboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 137);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 3;
            label1.Text = "Selecciona uno de tus contactos";
            // 
            // TablaContactos
            // 
            TablaContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TablaContactos.Location = new Point(40, 165);
            TablaContactos.Name = "TablaContactos";
            TablaContactos.ReadOnly = true;
            TablaContactos.RowTemplate.Height = 25;
            TablaContactos.Size = new Size(369, 212);
            TablaContactos.TabIndex = 4;
            // 
            // botonVolver
            // 
            botonVolver.Cursor = Cursors.Hand;
            botonVolver.Location = new Point(39, 392);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(75, 23);
            botonVolver.TabIndex = 5;
            botonVolver.Text = "Volver";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
            // 
            // FormTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 450);
            Controls.Add(botonVolver);
            Controls.Add(TablaContactos);
            Controls.Add(label1);
            Controls.Add(BtnPegarClipboard);
            Controls.Add(TxtBoxDatosCuenta);
            Controls.Add(labelIngresaDatos);
            Name = "FormTransferencia";
            Text = "FormTransferencia";
            ((System.ComponentModel.ISupportInitialize)TablaContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngresaDatos;
        private TextBox TxtBoxDatosCuenta;
        private Button BtnPegarClipboard;
        private Label label1;
        private DataGridView TablaContactos;
        private Button botonVolver;
    }
}