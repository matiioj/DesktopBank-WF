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
            SuspendLayout();
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.Location = new Point(30, 54);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(183, 20);
            labelIngrese.TabIndex = 23;
            labelIngrese.Text = "Ingrese el monto a extraer";
            // 
            // BtnExtract
            // 
            BtnExtract.Location = new Point(121, 130);
            BtnExtract.Name = "BtnExtract";
            BtnExtract.Size = new Size(75, 23);
            BtnExtract.TabIndex = 22;
            BtnExtract.Text = "Extract";
            BtnExtract.UseVisualStyleBackColor = true;
            BtnExtract.Click += BtnExtract_Click;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(26, 92);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(265, 23);
            TxtAmount.TabIndex = 21;
            // 
            // FormExtract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 207);
            Controls.Add(labelIngrese);
            Controls.Add(BtnExtract);
            Controls.Add(TxtAmount);
            Name = "FormExtract";
            Text = "FormExtract";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIngrese;
        private Button BtnExtract;
        private TextBox TxtAmount;
    }
}