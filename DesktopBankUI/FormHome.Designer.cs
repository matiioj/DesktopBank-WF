namespace DesktopBankUI
{
    partial class FormHome
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
            LabelBienvenido = new Label();
            LabelNombreDeUsuario = new Label();
            labelBalance = new Label();
            depositButton = new FontAwesome.Sharp.IconButton();
            extractButton = new FontAwesome.Sharp.IconButton();
            etqSaldo = new Label();
            comboBoxAccounts = new ComboBox();
            ChangeCurrencyButton = new Button();
            SuspendLayout();
            // 
            // LabelBienvenido
            // 
            LabelBienvenido.AutoSize = true;
            LabelBienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBienvenido.Location = new Point(36, 60);
            LabelBienvenido.Margin = new Padding(4, 0, 4, 0);
            LabelBienvenido.Name = "LabelBienvenido";
            LabelBienvenido.Size = new Size(196, 48);
            LabelBienvenido.TabIndex = 13;
            LabelBienvenido.Text = "Bienvenido";
            // 
            // LabelNombreDeUsuario
            // 
            LabelNombreDeUsuario.AutoSize = true;
            LabelNombreDeUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNombreDeUsuario.Location = new Point(199, 15);
            LabelNombreDeUsuario.Margin = new Padding(4, 0, 4, 0);
            LabelNombreDeUsuario.Name = "LabelNombreDeUsuario";
            LabelNombreDeUsuario.Size = new Size(0, 45);
            LabelNombreDeUsuario.TabIndex = 14;
            // 
            // labelBalance
            // 
            labelBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBalance.Location = new Point(377, 173);
            labelBalance.Margin = new Padding(4, 0, 4, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(343, 75);
            labelBalance.TabIndex = 15;
            labelBalance.Text = "_";
            labelBalance.Click += labelBalance_Click;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.Gainsboro;
            depositButton.FlatAppearance.BorderColor = Color.Black;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            depositButton.ForeColor = Color.Black;
            depositButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            depositButton.IconColor = Color.Black;
            depositButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            depositButton.IconSize = 30;
            depositButton.Location = new Point(45, 383);
            depositButton.Margin = new Padding(4, 5, 4, 5);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(402, 63);
            depositButton.TabIndex = 16;
            depositButton.Text = "  Deposit";
            depositButton.TextAlign = ContentAlignment.MiddleRight;
            depositButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // extractButton
            // 
            extractButton.BackColor = Color.Gainsboro;
            extractButton.FlatAppearance.BorderColor = Color.Black;
            extractButton.FlatStyle = FlatStyle.Flat;
            extractButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            extractButton.ForeColor = Color.Black;
            extractButton.IconChar = FontAwesome.Sharp.IconChar.ArrowTurnDown;
            extractButton.IconColor = Color.Black;
            extractButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            extractButton.IconSize = 24;
            extractButton.Location = new Point(496, 383);
            extractButton.Margin = new Padding(4, 5, 4, 5);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(407, 63);
            extractButton.TabIndex = 18;
            extractButton.Text = "  Extract";
            extractButton.TextAlign = ContentAlignment.MiddleRight;
            extractButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            extractButton.UseVisualStyleBackColor = false;
            extractButton.Click += extractButton_Click;
            // 
            // etqSaldo
            // 
            etqSaldo.AutoSize = true;
            etqSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            etqSaldo.Location = new Point(36, 173);
            etqSaldo.Name = "etqSaldo";
            etqSaldo.Size = new Size(301, 48);
            etqSaldo.TabIndex = 19;
            etqSaldo.Text = "Saldo disponible: ";
            // 
            // comboBoxAccounts
            // 
            comboBoxAccounts.FormattingEnabled = true;
            comboBoxAccounts.Location = new Point(1067, 143);
            comboBoxAccounts.Name = "comboBoxAccounts";
            comboBoxAccounts.Size = new Size(150, 33);
            comboBoxAccounts.TabIndex = 20;
            comboBoxAccounts.SelectedIndexChanged += comboBoxAccounts_SelectedIndexChanged;
            // 
            // ChangeCurrencyButton
            // 
            ChangeCurrencyButton.Location = new Point(1067, 65);
            ChangeCurrencyButton.Name = "ChangeCurrencyButton";
            ChangeCurrencyButton.Size = new Size(151, 53);
            ChangeCurrencyButton.TabIndex = 21;
            ChangeCurrencyButton.Text = "Change currency";
            ChangeCurrencyButton.UseVisualStyleBackColor = true;
            ChangeCurrencyButton.Click += ChangeCurrencyButton_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 239, 243);
            ClientSize = new Size(1329, 720);
            Controls.Add(ChangeCurrencyButton);
            Controls.Add(comboBoxAccounts);
            Controls.Add(etqSaldo);
            Controls.Add(extractButton);
            Controls.Add(depositButton);
            Controls.Add(labelBalance);
            Controls.Add(LabelNombreDeUsuario);
            Controls.Add(LabelBienvenido);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHome";
            Text = "FormHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LabelBienvenido;
        private Label LabelNombreDeUsuario;
        private Label labelBalance;
        private FontAwesome.Sharp.IconButton depositButton;
        private FontAwesome.Sharp.IconButton extractButton;
        private Label etqSaldo;
        private ComboBox comboBoxAccounts;
        private Button ChangeCurrencyButton;
    }
}