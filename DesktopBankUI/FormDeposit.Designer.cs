namespace DesktopBankUI
{
    partial class FormDeposit
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(37, 155);
            TxtAmount.Margin = new Padding(4, 5, 4, 5);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(377, 31);
            TxtAmount.TabIndex = 18;
            // 
            // BtnDepo
            // 
            BtnDepo.Location = new Point(149, 213);
            BtnDepo.Margin = new Padding(4, 5, 4, 5);
            BtnDepo.Name = "BtnDepo";
            BtnDepo.Size = new Size(147, 56);
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
            labelIngrese.Location = new Point(79, 119);
            labelIngrese.Margin = new Padding(4, 0, 4, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(307, 31);
            labelIngrese.TabIndex = 20;
            labelIngrese.Text = "Ingrese el monto a depositar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconPig;
            pictureBox1.Location = new Point(176, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // FormDeposit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(453, 345);
            Controls.Add(pictureBox1);
            Controls.Add(labelIngrese);
            Controls.Add(BtnDepo);
            Controls.Add(TxtAmount);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormDeposit";
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
    }
}