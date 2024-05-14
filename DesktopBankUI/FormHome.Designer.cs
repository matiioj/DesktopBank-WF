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
            flowLayoutPanel1 = new FlowLayoutPanel();
            moneySignIcon = new FontAwesome.Sharp.IconButton();
            recentTransactionsButton = new FontAwesome.Sharp.IconButton();
            helpButtonPanel = new FontAwesome.Sharp.IconButton();
            LabelBienvenido = new Label();
            LabelNombreDeUsuario = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(moneySignIcon);
            flowLayoutPanel1.Location = new Point(219, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 45);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // moneySignIcon
            // 
            moneySignIcon.AutoSize = true;
            moneySignIcon.Enabled = false;
            moneySignIcon.FlatAppearance.BorderSize = 0;
            moneySignIcon.FlatStyle = FlatStyle.Flat;
            moneySignIcon.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            moneySignIcon.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            moneySignIcon.IconColor = Color.Black;
            moneySignIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moneySignIcon.IconSize = 25;
            moneySignIcon.Location = new Point(3, 3);
            moneySignIcon.Name = "moneySignIcon";
            moneySignIcon.Size = new Size(75, 40);
            moneySignIcon.TabIndex = 0;
            moneySignIcon.Text = "AR";
            moneySignIcon.TextAlign = ContentAlignment.TopCenter;
            moneySignIcon.TextImageRelation = TextImageRelation.TextBeforeImage;
            moneySignIcon.UseVisualStyleBackColor = true;
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
            recentTransactionsButton.Location = new Point(219, 280);
            recentTransactionsButton.Name = "recentTransactionsButton";
            recentTransactionsButton.Size = new Size(360, 38);
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
            helpButtonPanel.Location = new Point(219, 363);
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
            LabelBienvenido.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBienvenido.Location = new Point(281, 36);
            LabelBienvenido.Name = "LabelBienvenido";
            LabelBienvenido.Size = new Size(121, 30);
            LabelBienvenido.TabIndex = 13;
            LabelBienvenido.Text = "Bienvenido";
            // 
            // LabelNombreDeUsuario
            // 
            LabelNombreDeUsuario.AutoSize = true;
            LabelNombreDeUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNombreDeUsuario.Location = new Point(408, 36);
            LabelNombreDeUsuario.Name = "LabelNombreDeUsuario";
            LabelNombreDeUsuario.Size = new Size(22, 30);
            LabelNombreDeUsuario.TabIndex = 14;
            LabelNombreDeUsuario.Text = "_";
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelNombreDeUsuario);
            Controls.Add(LabelBienvenido);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(recentTransactionsButton);
            Controls.Add(helpButtonPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHome";
            Text = "FormHome";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton moneySignIcon;
        private FontAwesome.Sharp.IconButton recentTransactionsButton;
        private FontAwesome.Sharp.IconButton helpButtonPanel;
        private Label LabelBienvenido;
        private Label LabelNombreDeUsuario;
    }
}