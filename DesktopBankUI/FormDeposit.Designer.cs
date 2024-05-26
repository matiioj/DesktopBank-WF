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
            SuspendLayout();
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(19, 80);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(265, 23);
            TxtAmount.TabIndex = 18;
            // 
            // BtnDepo
            // 
            BtnDepo.Location = new Point(114, 118);
            BtnDepo.Name = "BtnDepo";
            BtnDepo.Size = new Size(75, 23);
            BtnDepo.TabIndex = 19;
            BtnDepo.Text = "Deposit";
            BtnDepo.UseVisualStyleBackColor = true;
            BtnDepo.Click += BtnDepo_Click;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.Location = new Point(23, 42);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(200, 20);
            labelIngrese.TabIndex = 20;
            labelIngrese.Text = "Ingrese el monto a depositar";
            // 
            // FormDeposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 207);
            Controls.Add(labelIngrese);
            Controls.Add(BtnDepo);
            Controls.Add(TxtAmount);
            Name = "FormDeposit";
            Text = "FormDeposit";
            Load += FormDeposit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtAmount;
        private Button BtnDepo;
        private Label labelIngrese;
    }
}