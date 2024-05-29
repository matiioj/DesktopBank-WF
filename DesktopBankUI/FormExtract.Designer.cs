namespace DesktopBankUI
{
    partial class FormExtract
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
            labelIngrese = new Label();
            BtnExtract = new Button();
            TxtAmount = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = SystemColors.ControlLightLight;
            labelIngrese.Location = new Point(87, 117);
            labelIngrese.Margin = new Padding(4, 0, 4, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(281, 31);
            labelIngrese.TabIndex = 23;
            labelIngrese.Text = "Ingrese el monto a extraer";
            // 
            // BtnExtract
            // 
            BtnExtract.Location = new Point(136, 212);
            BtnExtract.Margin = new Padding(4, 5, 4, 5);
            BtnExtract.Name = "BtnExtract";
            BtnExtract.Size = new Size(163, 64);
            BtnExtract.TabIndex = 22;
            BtnExtract.Text = "Extraer";
            BtnExtract.UseVisualStyleBackColor = true;
            BtnExtract.Click += BtnExtract_Click;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(37, 153);
            TxtAmount.Margin = new Padding(4, 5, 4, 5);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(377, 31);
            TxtAmount.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(174, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // FormExtract
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(453, 345);
            Controls.Add(pictureBox1);
            Controls.Add(labelIngrese);
            Controls.Add(BtnExtract);
            Controls.Add(TxtAmount);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormExtract";
            Text = "Extracción";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngrese;
        private Button BtnExtract;
        private TextBox TxtAmount;
        private PictureBox pictureBox1;
    }
}