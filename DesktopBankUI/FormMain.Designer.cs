namespace DesktopBankUI
{
    partial class FormMain
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
            panelMenu = new Panel();
            btnLogOut = new FontAwesome.Sharp.IconButton();
            btnPayService = new FontAwesome.Sharp.IconButton();
            exitButton = new FontAwesome.Sharp.IconButton();
            transactionsButton = new FontAwesome.Sharp.IconButton();
            transferButton = new FontAwesome.Sharp.IconButton();
            cardButton = new FontAwesome.Sharp.IconButton();
            profileButton = new FontAwesome.Sharp.IconButton();
            homeButton = new FontAwesome.Sharp.IconButton();
            panelTitle = new Panel();
            iconIstic = new PictureBox();
            panelBanner = new Panel();
            etqBienvenida = new Label();
            etqSurnameOfAccount = new Label();
            etqNameUserOfAccount = new Label();
            etqTypeAccount = new Label();
            etqAccountStatic = new Label();
            minimizeButton = new FontAwesome.Sharp.IconButton();
            maximizeButton = new FontAwesome.Sharp.IconButton();
            restoreButton = new FontAwesome.Sharp.IconButton();
            closeButton = new FontAwesome.Sharp.IconButton();
            panelScreen = new Panel();
            panelMenu.SuspendLayout();
            panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconIstic).BeginInit();
            panelBanner.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Teal;
            panelMenu.Controls.Add(btnLogOut);
            panelMenu.Controls.Add(btnPayService);
            panelMenu.Controls.Add(exitButton);
            panelMenu.Controls.Add(transactionsButton);
            panelMenu.Controls.Add(transferButton);
            panelMenu.Controls.Add(cardButton);
            panelMenu.Controls.Add(profileButton);
            panelMenu.Controls.Add(homeButton);
            panelMenu.Controls.Add(panelTitle);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 5, 4, 5);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 0, 0, 42);
            panelMenu.Size = new Size(204, 788);
            panelMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Dock = DockStyle.Bottom;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnLogOut.IconColor = Color.White;
            btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogOut.IconSize = 30;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 630);
            btnLogOut.Margin = new Padding(4, 5, 4, 5);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(14, 0, 0, 0);
            btnLogOut.Size = new Size(204, 58);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = " Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnPayService
            // 
            btnPayService.Dock = DockStyle.Top;
            btnPayService.FlatAppearance.BorderSize = 0;
            btnPayService.FlatStyle = FlatStyle.Flat;
            btnPayService.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPayService.ForeColor = Color.White;
            btnPayService.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnPayService.IconColor = Color.White;
            btnPayService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPayService.IconSize = 30;
            btnPayService.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayService.Location = new Point(0, 432);
            btnPayService.Margin = new Padding(4, 5, 4, 5);
            btnPayService.Name = "btnPayService";
            btnPayService.Padding = new Padding(14, 0, 0, 0);
            btnPayService.Size = new Size(204, 58);
            btnPayService.TabIndex = 9;
            btnPayService.Text = "Pay Service";
            btnPayService.TextAlign = ContentAlignment.MiddleLeft;
            btnPayService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayService.UseVisualStyleBackColor = true;
            btnPayService.Click += btnPayService_Click;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            exitButton.IconColor = Color.White;
            exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            exitButton.IconSize = 30;
            exitButton.ImageAlign = ContentAlignment.MiddleLeft;
            exitButton.Location = new Point(0, 688);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(14, 0, 0, 0);
            exitButton.Size = new Size(204, 58);
            exitButton.TabIndex = 8;
            exitButton.Text = "  Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // transactionsButton
            // 
            transactionsButton.Dock = DockStyle.Top;
            transactionsButton.FlatAppearance.BorderSize = 0;
            transactionsButton.FlatStyle = FlatStyle.Flat;
            transactionsButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            transactionsButton.ForeColor = Color.White;
            transactionsButton.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            transactionsButton.IconColor = Color.White;
            transactionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            transactionsButton.IconSize = 30;
            transactionsButton.ImageAlign = ContentAlignment.MiddleLeft;
            transactionsButton.Location = new Point(0, 374);
            transactionsButton.Margin = new Padding(4, 5, 4, 5);
            transactionsButton.Name = "transactionsButton";
            transactionsButton.Padding = new Padding(14, 0, 0, 0);
            transactionsButton.Size = new Size(204, 58);
            transactionsButton.TabIndex = 6;
            transactionsButton.Text = "  Transactions";
            transactionsButton.TextAlign = ContentAlignment.MiddleLeft;
            transactionsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            transactionsButton.UseVisualStyleBackColor = true;
            transactionsButton.Click += transactionsButton_Click;
            // 
            // transferButton
            // 
            transferButton.Dock = DockStyle.Top;
            transferButton.FlatAppearance.BorderSize = 0;
            transferButton.FlatStyle = FlatStyle.Flat;
            transferButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            transferButton.ForeColor = Color.White;
            transferButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            transferButton.IconColor = Color.White;
            transferButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            transferButton.IconSize = 30;
            transferButton.ImageAlign = ContentAlignment.MiddleLeft;
            transferButton.Location = new Point(0, 316);
            transferButton.Margin = new Padding(4, 5, 4, 5);
            transferButton.Name = "transferButton";
            transferButton.Padding = new Padding(14, 0, 0, 0);
            transferButton.Size = new Size(204, 58);
            transferButton.TabIndex = 5;
            transferButton.Text = "  Transfer";
            transferButton.TextAlign = ContentAlignment.MiddleLeft;
            transferButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // cardButton
            // 
            cardButton.Dock = DockStyle.Top;
            cardButton.FlatAppearance.BorderSize = 0;
            cardButton.FlatStyle = FlatStyle.Flat;
            cardButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cardButton.ForeColor = Color.White;
            cardButton.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            cardButton.IconColor = Color.White;
            cardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cardButton.IconSize = 30;
            cardButton.ImageAlign = ContentAlignment.MiddleLeft;
            cardButton.Location = new Point(0, 258);
            cardButton.Margin = new Padding(4, 5, 4, 5);
            cardButton.Name = "cardButton";
            cardButton.Padding = new Padding(14, 0, 0, 0);
            cardButton.Size = new Size(204, 58);
            cardButton.TabIndex = 4;
            cardButton.Text = "  Card";
            cardButton.TextAlign = ContentAlignment.MiddleLeft;
            cardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cardButton.UseVisualStyleBackColor = true;
            cardButton.Click += cardButton_Click;
            // 
            // profileButton
            // 
            profileButton.Dock = DockStyle.Top;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            profileButton.ForeColor = Color.White;
            profileButton.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            profileButton.IconColor = Color.White;
            profileButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            profileButton.IconSize = 30;
            profileButton.ImageAlign = ContentAlignment.MiddleLeft;
            profileButton.Location = new Point(0, 200);
            profileButton.Margin = new Padding(4, 5, 4, 5);
            profileButton.Name = "profileButton";
            profileButton.Padding = new Padding(14, 0, 0, 0);
            profileButton.Size = new Size(204, 58);
            profileButton.TabIndex = 3;
            profileButton.Text = "  Profile";
            profileButton.TextAlign = ContentAlignment.MiddleLeft;
            profileButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // homeButton
            // 
            homeButton.Dock = DockStyle.Top;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.ForeColor = Color.White;
            homeButton.IconChar = FontAwesome.Sharp.IconChar.House;
            homeButton.IconColor = Color.White;
            homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeButton.IconSize = 30;
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(0, 142);
            homeButton.Margin = new Padding(4, 5, 4, 5);
            homeButton.Name = "homeButton";
            homeButton.Padding = new Padding(14, 0, 0, 0);
            homeButton.Size = new Size(204, 58);
            homeButton.TabIndex = 2;
            homeButton.Text = "  Home";
            homeButton.TextAlign = ContentAlignment.MiddleLeft;
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // panelTitle
            // 
            panelTitle.Controls.Add(iconIstic);
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Margin = new Padding(4, 5, 4, 5);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(204, 142);
            panelTitle.TabIndex = 1;
            // 
            // iconIstic
            // 
            iconIstic.Anchor = AnchorStyles.Top;
            iconIstic.Image = Properties.Resources.istic_logo;
            iconIstic.Location = new Point(53, 20);
            iconIstic.Margin = new Padding(4, 5, 4, 5);
            iconIstic.Name = "iconIstic";
            iconIstic.Size = new Size(89, 107);
            iconIstic.SizeMode = PictureBoxSizeMode.CenterImage;
            iconIstic.TabIndex = 0;
            iconIstic.TabStop = false;
            // 
            // panelBanner
            // 
            panelBanner.Controls.Add(etqBienvenida);
            panelBanner.Controls.Add(etqSurnameOfAccount);
            panelBanner.Controls.Add(etqNameUserOfAccount);
            panelBanner.Controls.Add(etqTypeAccount);
            panelBanner.Controls.Add(etqAccountStatic);
            panelBanner.Controls.Add(minimizeButton);
            panelBanner.Controls.Add(maximizeButton);
            panelBanner.Controls.Add(restoreButton);
            panelBanner.Controls.Add(closeButton);
            panelBanner.Dock = DockStyle.Top;
            panelBanner.Location = new Point(204, 0);
            panelBanner.Margin = new Padding(4, 5, 4, 5);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(1182, 100);
            panelBanner.TabIndex = 1;
            panelBanner.Paint += panelBanner_Paint;
            panelBanner.MouseDown += panelBanner_MouseDown;
            // 
            // etqBienvenida
            // 
            etqBienvenida.AutoSize = true;
            etqBienvenida.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            etqBienvenida.ForeColor = SystemColors.Control;
            etqBienvenida.Location = new Point(19, 9);
            etqBienvenida.Name = "etqBienvenida";
            etqBienvenida.Size = new Size(241, 37);
            etqBienvenida.TabIndex = 8;
            etqBienvenida.Text = "Client       :";
            // 
            // etqSurnameOfAccount
            // 
            etqSurnameOfAccount.AutoSize = true;
            etqSurnameOfAccount.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            etqSurnameOfAccount.ForeColor = SystemColors.Control;
            etqSurnameOfAccount.Location = new Point(555, 9);
            etqSurnameOfAccount.Name = "etqSurnameOfAccount";
            etqSurnameOfAccount.Size = new Size(0, 37);
            etqSurnameOfAccount.TabIndex = 7;
            etqSurnameOfAccount.Click += etqSurnameOfAccount_Click;
            // 
            // etqNameUserOfAccount
            // 
            etqNameUserOfAccount.AutoSize = true;
            etqNameUserOfAccount.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            etqNameUserOfAccount.ForeColor = SystemColors.Control;
            etqNameUserOfAccount.Location = new Point(378, 9);
            etqNameUserOfAccount.Name = "etqNameUserOfAccount";
            etqNameUserOfAccount.Size = new Size(0, 37);
            etqNameUserOfAccount.TabIndex = 6;
            etqNameUserOfAccount.Click += etqNameUserOfAccount_Click;
            // 
            // etqTypeAccount
            // 
            etqTypeAccount.AutoSize = true;
            etqTypeAccount.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            etqTypeAccount.ForeColor = SystemColors.Control;
            etqTypeAccount.Location = new Point(378, 54);
            etqTypeAccount.Name = "etqTypeAccount";
            etqTypeAccount.Size = new Size(113, 37);
            etqTypeAccount.TabIndex = 5;
            etqTypeAccount.Text = "asdasd";
            etqTypeAccount.Click += etqTypeAccount_Click;
            // 
            // etqAccountStatic
            // 
            etqAccountStatic.AutoSize = true;
            etqAccountStatic.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            etqAccountStatic.ForeColor = SystemColors.Control;
            etqAccountStatic.Location = new Point(19, 54);
            etqAccountStatic.Name = "etqAccountStatic";
            etqAccountStatic.Size = new Size(257, 37);
            etqAccountStatic.TabIndex = 4;
            etqAccountStatic.Text = "Account Type : ";
            etqAccountStatic.Click += etqAccountStatic_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            minimizeButton.IconColor = Color.Black;
            minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimizeButton.IconSize = 25;
            minimizeButton.Location = new Point(1055, 0);
            minimizeButton.Margin = new Padding(4, 5, 4, 5);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(36, 42);
            minimizeButton.TabIndex = 3;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // maximizeButton
            // 
            maximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeButton.BackColor = Color.Transparent;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximizeButton.IconColor = Color.Black;
            maximizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizeButton.IconSize = 25;
            maximizeButton.Location = new Point(1100, 0);
            maximizeButton.Margin = new Padding(4, 5, 4, 5);
            maximizeButton.Name = "maximizeButton";
            maximizeButton.Size = new Size(36, 42);
            maximizeButton.TabIndex = 2;
            maximizeButton.UseVisualStyleBackColor = false;
            maximizeButton.Click += maximizeButton_Click;
            // 
            // restoreButton
            // 
            restoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            restoreButton.BackColor = Color.Transparent;
            restoreButton.FlatAppearance.BorderSize = 0;
            restoreButton.FlatStyle = FlatStyle.Flat;
            restoreButton.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            restoreButton.IconColor = Color.Black;
            restoreButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restoreButton.IconSize = 25;
            restoreButton.Location = new Point(1100, 0);
            restoreButton.Margin = new Padding(4, 5, 4, 5);
            restoreButton.Name = "restoreButton";
            restoreButton.Size = new Size(36, 42);
            restoreButton.TabIndex = 1;
            restoreButton.UseVisualStyleBackColor = false;
            restoreButton.Visible = false;
            restoreButton.Click += restoreButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.Transparent;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            closeButton.IconColor = Color.Black;
            closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            closeButton.IconSize = 25;
            closeButton.Location = new Point(1142, 0);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(36, 42);
            closeButton.TabIndex = 0;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // panelScreen
            // 
            panelScreen.BackColor = Color.White;
            panelScreen.Dock = DockStyle.Fill;
            panelScreen.Location = new Point(204, 100);
            panelScreen.Margin = new Padding(4, 5, 4, 5);
            panelScreen.Name = "panelScreen";
            panelScreen.Size = new Size(1182, 688);
            panelScreen.TabIndex = 2;
            panelScreen.Paint += panelScreen_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 788);
            Controls.Add(panelScreen);
            Controls.Add(panelBanner);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconIstic).EndInit();
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelBanner;
        private Panel panelScreen;
        private Panel panelTitle;
        private FontAwesome.Sharp.IconButton homeButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton transactionsButton;
        private FontAwesome.Sharp.IconButton transferButton;
        private FontAwesome.Sharp.IconButton cardButton;
        private FontAwesome.Sharp.IconButton profileButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private FontAwesome.Sharp.IconButton maximizeButton;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private PictureBox iconIstic;
        private FontAwesome.Sharp.IconButton restoreButton;
        private FontAwesome.Sharp.IconButton btnPayService;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private Label etqAccountStatic;
        private Label etqTypeAccount;
        private Label etqNameUserOfAccount;
        private Label etqSurnameOfAccount;
        private Label etqBienvenida;
    }
}