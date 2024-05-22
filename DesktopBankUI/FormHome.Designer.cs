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
            helpButtonPanel.Location = new Point(21, 433);
            helpButtonPanel.Margin = new Padding(4, 5, 4, 5);
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
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 720);
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
    }
}