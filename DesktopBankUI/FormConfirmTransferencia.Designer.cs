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
            availableBalanceTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(102, 240);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(297, 23);
            TxtAmount.TabIndex = 18;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = SystemColors.ControlLightLight;
            labelIngrese.Location = new Point(102, 215);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(253, 24);
            labelIngrese.TabIndex = 20;
            labelIngrese.Text = "Ingrese el monto a transferir";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(214, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // personToTransferTxt
            // 
            personToTransferTxt.AutoSize = true;
            personToTransferTxt.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            personToTransferTxt.ForeColor = SystemColors.ControlLightLight;
            personToTransferTxt.Location = new Point(102, 140);
            personToTransferTxt.Name = "personToTransferTxt";
            personToTransferTxt.Size = new Size(0, 24);
            personToTransferTxt.TabIndex = 22;
            // 
            // BtnTransferir
            // 
            BtnTransferir.Location = new Point(102, 265);
            BtnTransferir.Name = "BtnTransferir";
            BtnTransferir.Size = new Size(103, 40);
            BtnTransferir.TabIndex = 23;
            BtnTransferir.Text = "Transferir";
            BtnTransferir.UseVisualStyleBackColor = true;
            BtnTransferir.Click += BtnTransferir_Click;
            // 
            // btnGuardarComprobante
            // 
            btnGuardarComprobante.Location = new Point(245, 265);
            btnGuardarComprobante.Name = "btnGuardarComprobante";
            btnGuardarComprobante.Size = new Size(153, 40);
            btnGuardarComprobante.TabIndex = 24;
            btnGuardarComprobante.Text = "Guardar Último Comprobante";
            btnGuardarComprobante.UseVisualStyleBackColor = true;
            btnGuardarComprobante.Click += btnGuardarComprobante_Click;
            // 
            // availableBalanceTxt
            // 
            availableBalanceTxt.AutoSize = true;
            availableBalanceTxt.Font = new Font("Trebuchet MS", 14F, FontStyle.Regular, GraphicsUnit.Point);
            availableBalanceTxt.ForeColor = SystemColors.ControlLightLight;
            availableBalanceTxt.Location = new Point(102, 65);
            availableBalanceTxt.Name = "availableBalanceTxt";
            availableBalanceTxt.Size = new Size(0, 24);
            availableBalanceTxt.TabIndex = 25;
            // 
            // FormConfirmTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(489, 336);
            Controls.Add(availableBalanceTxt);
            Controls.Add(btnGuardarComprobante);
            Controls.Add(BtnTransferir);
            Controls.Add(personToTransferTxt);
            Controls.Add(pictureBox1);
            Controls.Add(labelIngrese);
            Controls.Add(TxtAmount);
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
        private Label availableBalanceTxt;
    }
}