namespace DesktopBankUI
{
    partial class FormTransactions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            saveFileDialog1 = new SaveFileDialog();
            DataGridTransactions = new DataGridView();
            lblTransferCount = new Label();
            lblDepositTotal = new Label();
            lblWithdrawalTotal = new Label();
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
            DataGridTransactions.CellClick += DataGridTransactions_CellClick;
            // 
            // lblTransferCount
            // 
            lblTransferCount.AutoSize = true;
            lblTransferCount.Location = new Point(12, 410);
            lblTransferCount.Name = "lblTransferCount";
            lblTransferCount.Size = new Size(132, 15);
            lblTransferCount.TabIndex = 1;
            lblTransferCount.Text = "Número de transferencias:";
            // 
            // lblDepositTotal
            // 
            lblDepositTotal.AutoSize = true;
            lblDepositTotal.Location = new Point(12, 430);
            lblDepositTotal.Name = "lblDepositTotal";
            lblDepositTotal.Size = new Size(88, 15);
            lblDepositTotal.TabIndex = 2;
            lblDepositTotal.Text = "Total de depósitos:";
            // 
            // lblWithdrawalTotal
            // 
            lblWithdrawalTotal.AutoSize = true;
            lblWithdrawalTotal.Location = new Point(12, 450);
            lblWithdrawalTotal.Name = "lblWithdrawalTotal";
            lblWithdrawalTotal.Size = new Size(79, 15);
            lblWithdrawalTotal.TabIndex = 3;
            lblWithdrawalTotal.Text = "Total de retiros:";
            // 
            // FormTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 480); // Aumentar la altura del formulario para que los labels se vean
            Controls.Add(lblTransferCount);
            Controls.Add(lblDepositTotal);
            Controls.Add(lblWithdrawalTotal);
            Controls.Add(DataGridTransactions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTransactions";
            Text = "FormTransactions";
            ((System.ComponentModel.ISupportInitialize)DataGridTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private DataGridView DataGridTransactions;
        private SaveFileDialog saveFileDialog1;
        private Label lblTransferCount;
        private Label lblDepositTotal;
        private Label lblWithdrawalTotal;
    }
}