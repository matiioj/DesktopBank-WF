namespace DesktopBankUI
{
    partial class FormConfirmTransferencia
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
            TxtAmount = new TextBox();
            labelIngrese = new Label();
            pictureBox1 = new PictureBox();
            personToTransferTxt = new Label();
            BtnTransferir = new Button();
            saveFileDialog1 = new SaveFileDialog();
            btnGuardarComprobante = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(145, 325);
            TxtAmount.Margin = new Padding(4, 5, 4, 5);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(423, 31);
            TxtAmount.TabIndex = 18;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = SystemColors.ControlLightLight;
            labelIngrese.Location = new Point(145, 284);
            labelIngrese.Margin = new Padding(4, 0, 4, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(371, 36);
            labelIngrese.TabIndex = 20;
            labelIngrese.Text = "Ingrese el monto a transferir";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(305, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // personToTransferTxt
            // 
            personToTransferTxt.AutoSize = true;
            personToTransferTxt.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            personToTransferTxt.ForeColor = SystemColors.ControlLightLight;
            personToTransferTxt.Location = new Point(89, 143);
            personToTransferTxt.Margin = new Padding(4, 0, 4, 0);
            personToTransferTxt.Name = "personToTransferTxt";
            personToTransferTxt.Size = new Size(0, 36);
            personToTransferTxt.TabIndex = 22;
            // 
            // BtnTransferir
            // 
            BtnTransferir.Location = new Point(145, 366);
            BtnTransferir.Margin = new Padding(4, 5, 4, 5);
            BtnTransferir.Name = "BtnTransferir";
            BtnTransferir.Size = new Size(147, 66);
            BtnTransferir.TabIndex = 23;
            BtnTransferir.Text = "Transferir";
            BtnTransferir.UseVisualStyleBackColor = true;
            BtnTransferir.Click += BtnTransferir_Click;
            // 
            // btnGuardarComprobante
            // 
            btnGuardarComprobante.Location = new Point(350, 366);
            btnGuardarComprobante.Margin = new Padding(4, 5, 4, 5);
            btnGuardarComprobante.Name = "btnGuardarComprobante";
            btnGuardarComprobante.Size = new Size(218, 66);
            btnGuardarComprobante.TabIndex = 24;
            btnGuardarComprobante.Text = "Guardar Último Comprobante";
            btnGuardarComprobante.UseVisualStyleBackColor = true;
            btnGuardarComprobante.Click += btnGuardarComprobante_Click;
            // 
            // FormConfirmTransferencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(699, 518);
            Controls.Add(btnGuardarComprobante);
            Controls.Add(BtnTransferir);
            Controls.Add(personToTransferTxt);
            Controls.Add(pictureBox1);
            Controls.Add(labelIngrese);
            Controls.Add(TxtAmount);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormConfirmTransferencia";
            Text = "Transferir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAmount;
        private Label labelIngrese;
        private PictureBox pictureBox1;
        private Label personToTransferTxt;
        private Button BtnTransferir;
        private SaveFileDialog saveFileDialog1;
        private Button btnGuardarComprobante;
    }
}