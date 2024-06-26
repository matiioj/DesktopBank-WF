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
            helpButtonPanel = new FontAwesome.Sharp.IconButton();
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
            // helpButtonPanel
            // 
            helpButtonPanel.BackColor = Color.Gainsboro;
            helpButtonPanel.FlatAppearance.BorderColor = Color.Black;
            helpButtonPanel.FlatStyle = FlatStyle.Flat;
            helpButtonPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            helpButtonPanel.ForeColor = Color.Black;
            helpButtonPanel.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            helpButtonPanel.IconColor = Color.Black;
            helpButtonPanel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            helpButtonPanel.IconSize = 30;
            helpButtonPanel.Location = new Point(99, 337);
            helpButtonPanel.Name = "helpButtonPanel";
            helpButtonPanel.Size = new Size(360, 38);
            helpButtonPanel.TabIndex = 10;
            helpButtonPanel.Text = "  Help";
            helpButtonPanel.TextAlign = ContentAlignment.MiddleRight;
            helpButtonPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            helpButtonPanel.UseVisualStyleBackColor = false;
            // 
            // LabelBienvenido
            // 
            LabelBienvenido.AutoSize = true;
            LabelBienvenido.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBienvenido.Location = new Point(25, 36);
            LabelBienvenido.Name = "LabelBienvenido";
            LabelBienvenido.Size = new Size(134, 32);
            LabelBienvenido.TabIndex = 13;
            LabelBienvenido.Text = "Bienvenido";
            // 
            // LabelNombreDeUsuario
            // 
            LabelNombreDeUsuario.AutoSize = true;
            LabelNombreDeUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNombreDeUsuario.Location = new Point(139, 9);
            LabelNombreDeUsuario.Name = "LabelNombreDeUsuario";
            LabelNombreDeUsuario.Size = new Size(0, 30);
            LabelNombreDeUsuario.TabIndex = 14;
            // 
            // labelBalance
            // 
            labelBalance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBalance.Location = new Point(264, 104);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(240, 45);
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
            depositButton.Location = new Point(99, 230);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(360, 38);
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
            extractButton.Location = new Point(99, 284);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(360, 38);
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
            etqSaldo.Location = new Point(25, 104);
            etqSaldo.Margin = new Padding(2, 0, 2, 0);
            etqSaldo.Name = "etqSaldo";
            etqSaldo.Size = new Size(203, 32);
            etqSaldo.TabIndex = 19;
            etqSaldo.Text = "Saldo disponible: ";
            // 
            // comboBoxAccounts
            // 
            comboBoxAccounts.FormattingEnabled = true;
            comboBoxAccounts.Location = new Point(545, 98);
            comboBoxAccounts.Margin = new Padding(2);
            comboBoxAccounts.Name = "comboBoxAccounts";
            comboBoxAccounts.Size = new Size(106, 23);
            comboBoxAccounts.TabIndex = 20;
            // 
            // ChangeCurrencyButton
            // 
            ChangeCurrencyButton.Location = new Point(545, 51);
            ChangeCurrencyButton.Margin = new Padding(2);
            ChangeCurrencyButton.Name = "ChangeCurrencyButton";
            ChangeCurrencyButton.Size = new Size(106, 32);
            ChangeCurrencyButton.TabIndex = 21;
            ChangeCurrencyButton.Text = "Change currency";
            ChangeCurrencyButton.UseVisualStyleBackColor = true;
            ChangeCurrencyButton.Click += ChangeCurrencyButton_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 239, 243);
            ClientSize = new Size(800, 432);
            Controls.Add(ChangeCurrencyButton);
            Controls.Add(comboBoxAccounts);
            Controls.Add(etqSaldo);
            Controls.Add(extractButton);
            Controls.Add(depositButton);
            Controls.Add(labelBalance);
            Controls.Add(LabelNombreDeUsuario);
            Controls.Add(LabelBienvenido);
            Controls.Add(helpButtonPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            Text = "FormHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton helpButtonPanel;
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