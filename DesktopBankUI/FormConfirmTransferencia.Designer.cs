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
            BtnDepo = new Button();
            labelIngrese = new Label();
            pictureBox1 = new PictureBox();
            personToTransferTxt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(26, 130);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(265, 23);
            TxtAmount.TabIndex = 18;
            // 
            // BtnDepo
            // 
            BtnDepo.Location = new Point(104, 165);
            BtnDepo.Name = "BtnDepo";
            BtnDepo.Size = new Size(103, 34);
            BtnDepo.TabIndex = 19;
            BtnDepo.Text = "Depositar";
            BtnDepo.UseVisualStyleBackColor = true;
            BtnDepo.Click += BtnDepo_Click;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = SystemColors.ControlLightLight;
            labelIngrese.Location = new Point(55, 108);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(196, 20);
            labelIngrese.TabIndex = 20;
            labelIngrese.Text = "Ingrese el monto a transferir";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(123, 17);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // personToTransferTxt
            // 
            personToTransferTxt.AutoSize = true;
            personToTransferTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            personToTransferTxt.ForeColor = SystemColors.ControlLightLight;
            personToTransferTxt.Location = new Point(55, 78);
            personToTransferTxt.Name = "personToTransferTxt";
            personToTransferTxt.Size = new Size(196, 20);
            personToTransferTxt.TabIndex = 22;
            personToTransferTxt.Text = "Ingrese el monto a transferir";
            // 
            // FormConfirmTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(317, 207);
            Controls.Add(personToTransferTxt);
            Controls.Add(pictureBox1);
            Controls.Add(labelIngrese);
            Controls.Add(BtnDepo);
            Controls.Add(TxtAmount);
            Name = "FormConfirmTransferencia";
            Text = "Depositar";
            Load += FormDeposit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAmount;
        private Button BtnDepo;
        private Label labelIngrese;
        private PictureBox pictureBox1;
        private Label personToTransferTxt;
    }
}