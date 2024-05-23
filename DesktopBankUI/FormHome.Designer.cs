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
            recentTransactionsButton = new FontAwesome.Sharp.IconButton();
            helpButtonPanel = new FontAwesome.Sharp.IconButton();
            LabelBienvenido = new Label();
            LabelNombreDeUsuario = new Label();
            labelBalance = new Label();
            depositButton = new FontAwesome.Sharp.IconButton();
            TxtAmount = new TextBox();
            extractButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // recentTransactionsButton
            // 
            recentTransactionsButton.BackColor = Color.Gainsboro;
            recentTransactionsButton.FlatAppearance.BorderColor = Color.Black;
            recentTransactionsButton.FlatStyle = FlatStyle.Flat;
            recentTransactionsButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            recentTransactionsButton.ForeColor = Color.Black;
            recentTransactionsButton.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            recentTransactionsButton.IconColor = Color.Black;
            recentTransactionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            recentTransactionsButton.IconSize = 30;
            recentTransactionsButton.Location = new Point(21, 295);
            recentTransactionsButton.Margin = new Padding(4, 5, 4, 5);
            recentTransactionsButton.Name = "recentTransactionsButton";
            recentTransactionsButton.Size = new Size(514, 63);
            recentTransactionsButton.TabIndex = 11;
            recentTransactionsButton.Text = "  See transactions";
            recentTransactionsButton.TextAlign = ContentAlignment.MiddleRight;
            recentTransactionsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            recentTransactionsButton.UseVisualStyleBackColor = false;
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
<<<<<<< HEAD
            helpButtonPanel.Location = new Point(21, 433);
            helpButtonPanel.Margin = new Padding(4, 5, 4, 5);
=======
            helpButtonPanel.Location = new Point(15, 365);
>>>>>>> origin/operationRepositories
            helpButtonPanel.Name = "helpButtonPanel";
            helpButtonPanel.Size = new Size(514, 63);
            helpButtonPanel.TabIndex = 10;
            helpButtonPanel.Text = "  Help";
            helpButtonPanel.TextAlign = ContentAlignment.MiddleRight;
            helpButtonPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            helpButtonPanel.UseVisualStyleBackColor = false;
            // 
            // LabelBienvenido
            // 
            LabelBienvenido.AutoSize = true;
            LabelBienvenido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBienvenido.Location = new Point(17, 15);
            LabelBienvenido.Margin = new Padding(4, 0, 4, 0);
            LabelBienvenido.Name = "LabelBienvenido";
            LabelBienvenido.Size = new Size(177, 45);
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
            labelBalance.Location = new Point(29, 107);
            labelBalance.Margin = new Padding(4, 0, 4, 0);
            labelBalance.Name = "labelBalance";
            labelBalance.Size = new Size(343, 75);
            labelBalance.TabIndex = 15;
            labelBalance.Text = "_";
            
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
            depositButton.Location = new Point(15, 277);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(360, 38);
            depositButton.TabIndex = 16;
            depositButton.Text = "  Deposit";
            depositButton.TextAlign = ContentAlignment.MiddleRight;
            depositButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // TxtAmount
            // 
            TxtAmount.Location = new Point(15, 248);
            TxtAmount.Name = "TxtAmount";
            TxtAmount.Size = new Size(265, 23);
            TxtAmount.TabIndex = 17;
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
            extractButton.Location = new Point(15, 321);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(360, 38);
            extractButton.TabIndex = 18;
            extractButton.Text = "  Extract";
            extractButton.TextAlign = ContentAlignment.MiddleRight;
            extractButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            extractButton.UseVisualStyleBackColor = false;
            extractButton.Click += extractButton_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(1143, 720);
=======
            ClientSize = new Size(800, 432);
            Controls.Add(extractButton);
            Controls.Add(TxtAmount);
            Controls.Add(depositButton);
>>>>>>> origin/operationRepositories
            Controls.Add(labelBalance);
            Controls.Add(LabelNombreDeUsuario);
            Controls.Add(LabelBienvenido);
            Controls.Add(recentTransactionsButton);
            Controls.Add(helpButtonPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHome";
            Text = "FormHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton recentTransactionsButton;
        private FontAwesome.Sharp.IconButton helpButtonPanel;
        private Label LabelBienvenido;
        private Label LabelNombreDeUsuario;
        private Label labelBalance;
        private FontAwesome.Sharp.IconButton depositButton;
        private TextBox TxtAmount;
        private FontAwesome.Sharp.IconButton extractButton;
    }
}