namespace DesktopBankUI
{
    partial class FormTransactions
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
            DataGridTransactions = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridTransactions).BeginInit();
            SuspendLayout();
            // 
            // DataGridTransactions
            // 
            DataGridTransactions.AllowUserToAddRows = false;
            DataGridTransactions.AllowUserToDeleteRows = false;
            DataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridTransactions.Location = new Point(12, 33);
            DataGridTransactions.Name = "DataGridTransactions";
            DataGridTransactions.RowTemplate.Height = 25;
            DataGridTransactions.Size = new Size(587, 369);
            DataGridTransactions.TabIndex = 0;
            // 
            // FormTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(DataGridTransactions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransactions";
            Text = "FormTransactions";
            ((System.ComponentModel.ISupportInitialize)DataGridTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataGridTransactions;
    }
}