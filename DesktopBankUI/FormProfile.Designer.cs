namespace DesktopBankUI
{
    partial class FormProfile
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
            LabelPerfil = new Label();
            LabelCbu = new Label();
            LabelCuil = new Label();
            LabelAlias = new Label();
            LabelContenidoCbu = new Label();
            LabelContenidoAlias = new Label();
            LabelContenidoCuil = new Label();
            btnCopy = new Button();
            gbPersonalData = new GroupBox();
            panelCambiarContra = new Panel();
            btnCancelarContra = new Button();
            btnAceptarContra = new Button();
            txtCambiarContra = new TextBox();
            panelAceptarMail = new Panel();
            btnCancelarMail = new Button();
            btnAceptarMail = new Button();
            txtCambiarMail = new TextBox();
            panelCambiarAlias = new Panel();
            btnCancelarAlias = new Button();
            btnAceptarAlias = new Button();
            txtCambiarAlias = new TextBox();
            btnCambiarAlias = new Button();
            btnChangePassFormPerfil = new Button();
            btnChangeMail = new Button();
            btnCopyAlias = new Button();
            gbPersonalData.SuspendLayout();
            panelCambiarContra.SuspendLayout();
            panelAceptarMail.SuspendLayout();
            panelCambiarAlias.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPerfil
            // 
            LabelPerfil.AutoSize = true;
            LabelPerfil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPerfil.Location = new Point(0, 9);
            LabelPerfil.Name = "LabelPerfil";
            LabelPerfil.Size = new Size(91, 45);
            LabelPerfil.TabIndex = 0;
            LabelPerfil.Text = "Perfil";
            LabelPerfil.Click += LabelPerfil_Click;
            // 
            // LabelCbu
            // 
            LabelCbu.AutoSize = true;
            LabelCbu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCbu.Location = new Point(11, 259);
            LabelCbu.Name = "LabelCbu";
            LabelCbu.Size = new Size(80, 45);
            LabelCbu.TabIndex = 1;
            LabelCbu.Text = "CBU";
            // 
            // LabelCuil
            // 
            LabelCuil.AutoSize = true;
            LabelCuil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCuil.Location = new Point(11, 346);
            LabelCuil.Name = "LabelCuil";
            LabelCuil.Size = new Size(86, 45);
            LabelCuil.TabIndex = 2;
            LabelCuil.Text = "CUIL";
            // 
            // LabelAlias
            // 
            LabelAlias.AutoSize = true;
            LabelAlias.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAlias.Location = new Point(11, 301);
            LabelAlias.Name = "LabelAlias";
            LabelAlias.Size = new Size(87, 45);
            LabelAlias.TabIndex = 4;
            LabelAlias.Text = "Alias";
            // 
            // LabelContenidoCbu
            // 
            LabelContenidoCbu.AutoSize = true;
            LabelContenidoCbu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCbu.Location = new Point(146, 259);
            LabelContenidoCbu.Name = "LabelContenidoCbu";
            LabelContenidoCbu.Size = new Size(33, 45);
            LabelContenidoCbu.TabIndex = 5;
            LabelContenidoCbu.Text = "_";
            LabelContenidoCbu.Click += LabelContenidoCbu_Click;
            // 
            // LabelContenidoAlias
            // 
            LabelContenidoAlias.AutoSize = true;
            LabelContenidoAlias.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoAlias.Location = new Point(146, 299);
            LabelContenidoAlias.Name = "LabelContenidoAlias";
            LabelContenidoAlias.Size = new Size(33, 45);
            LabelContenidoAlias.TabIndex = 6;
            LabelContenidoAlias.Text = "_";
            // 
            // LabelContenidoCuil
            // 
            LabelContenidoCuil.AutoSize = true;
            LabelContenidoCuil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCuil.Location = new Point(146, 350);
            LabelContenidoCuil.Name = "LabelContenidoCuil";
            LabelContenidoCuil.Size = new Size(33, 45);
            LabelContenidoCuil.TabIndex = 8;
            LabelContenidoCuil.Text = "_";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(255, 128, 0);
            btnCopy.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopy.ForeColor = SystemColors.ButtonHighlight;
            btnCopy.Location = new Point(678, 259);
            btnCopy.Margin = new Padding(2);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(161, 32);
            btnCopy.TabIndex = 9;
            btnCopy.Text = "COPIAR CBU";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // gbPersonalData
            // 
            gbPersonalData.BackColor = Color.FromArgb(214, 219, 223);
            gbPersonalData.Controls.Add(panelCambiarContra);
            gbPersonalData.Controls.Add(panelAceptarMail);
            gbPersonalData.Controls.Add(panelCambiarAlias);
            gbPersonalData.Controls.Add(btnCambiarAlias);
            gbPersonalData.Controls.Add(btnChangePassFormPerfil);
            gbPersonalData.Controls.Add(btnChangeMail);
            gbPersonalData.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbPersonalData.Location = new Point(11, 72);
            gbPersonalData.Margin = new Padding(2);
            gbPersonalData.Name = "gbPersonalData";
            gbPersonalData.Padding = new Padding(2);
            gbPersonalData.Size = new Size(865, 163);
            gbPersonalData.TabIndex = 10;
            gbPersonalData.TabStop = false;
            gbPersonalData.Text = "Datos Personales";
            gbPersonalData.Enter += gbPersonalData_Enter;
            // 
            // panelCambiarContra
            // 
            panelCambiarContra.Controls.Add(btnCancelarContra);
            panelCambiarContra.Controls.Add(btnAceptarContra);
            panelCambiarContra.Controls.Add(txtCambiarContra);
            panelCambiarContra.Location = new Point(318, 77);
            panelCambiarContra.Margin = new Padding(2);
            panelCambiarContra.Name = "panelCambiarContra";
            panelCambiarContra.Size = new Size(239, 82);
            panelCambiarContra.TabIndex = 5;
            panelCambiarContra.Visible = false;
            // 
            // btnCancelarContra
            // 
            btnCancelarContra.Location = new Point(144, 42);
            btnCancelarContra.Margin = new Padding(2);
            btnCancelarContra.Name = "btnCancelarContra";
            btnCancelarContra.Size = new Size(84, 30);
            btnCancelarContra.TabIndex = 12;
            btnCancelarContra.Text = "Cancelar";
            btnCancelarContra.UseVisualStyleBackColor = true;
            btnCancelarContra.Click += btnCancelarContra_Click;
            // 
            // btnAceptarContra
            // 
            btnAceptarContra.Location = new Point(10, 42);
            btnAceptarContra.Margin = new Padding(2);
            btnAceptarContra.Name = "btnAceptarContra";
            btnAceptarContra.Size = new Size(83, 30);
            btnAceptarContra.TabIndex = 1;
            btnAceptarContra.Text = "Aceptar";
            btnAceptarContra.UseVisualStyleBackColor = true;
            btnAceptarContra.Click += btnAceptarContra_Click;
            // 
            // txtCambiarContra
            // 
            txtCambiarContra.Location = new Point(8, 8);
            txtCambiarContra.Margin = new Padding(2);
            txtCambiarContra.Name = "txtCambiarContra";
            txtCambiarContra.Size = new Size(220, 26);
            txtCambiarContra.TabIndex = 0;
            txtCambiarContra.TextChanged += txtCambiarContra_TextChanged;
            // 
            // panelAceptarMail
            // 
            panelAceptarMail.Controls.Add(btnCancelarMail);
            panelAceptarMail.Controls.Add(btnAceptarMail);
            panelAceptarMail.Controls.Add(txtCambiarMail);
            panelAceptarMail.Location = new Point(12, 77);
            panelAceptarMail.Margin = new Padding(2);
            panelAceptarMail.Name = "panelAceptarMail";
            panelAceptarMail.Size = new Size(281, 82);
            panelAceptarMail.TabIndex = 4;
            panelAceptarMail.Visible = false;
            // 
            // btnCancelarMail
            // 
            btnCancelarMail.Location = new Point(148, 42);
            btnCancelarMail.Margin = new Padding(2);
            btnCancelarMail.Name = "btnCancelarMail";
            btnCancelarMail.Size = new Size(123, 30);
            btnCancelarMail.TabIndex = 12;
            btnCancelarMail.Text = "Cancelar";
            btnCancelarMail.UseVisualStyleBackColor = true;
            btnCancelarMail.Click += btnCancelarMail_Click;
            // 
            // btnAceptarMail
            // 
            btnAceptarMail.Location = new Point(10, 42);
            btnAceptarMail.Margin = new Padding(2);
            btnAceptarMail.Name = "btnAceptarMail";
            btnAceptarMail.Size = new Size(123, 30);
            btnAceptarMail.TabIndex = 1;
            btnAceptarMail.Text = "Aceptar";
            btnAceptarMail.UseVisualStyleBackColor = true;
            btnAceptarMail.Click += btnAceptarMail_Click;
            // 
            // txtCambiarMail
            // 
            txtCambiarMail.Location = new Point(10, 8);
            txtCambiarMail.Margin = new Padding(2);
            txtCambiarMail.Name = "txtCambiarMail";
            txtCambiarMail.Size = new Size(261, 26);
            txtCambiarMail.TabIndex = 0;
            // 
            // panelCambiarAlias
            // 
            panelCambiarAlias.Controls.Add(btnCancelarAlias);
            panelCambiarAlias.Controls.Add(btnAceptarAlias);
            panelCambiarAlias.Controls.Add(txtCambiarAlias);
            panelCambiarAlias.Location = new Point(561, 77);
            panelCambiarAlias.Margin = new Padding(2);
            panelCambiarAlias.Name = "panelCambiarAlias";
            panelCambiarAlias.Size = new Size(300, 82);
            panelCambiarAlias.TabIndex = 3;
            panelCambiarAlias.Visible = false;
            panelCambiarAlias.Paint += panelCambiarAlias_Paint;
            // 
            // btnCancelarAlias
            // 
            btnCancelarAlias.Location = new Point(177, 42);
            btnCancelarAlias.Margin = new Padding(2);
            btnCancelarAlias.Name = "btnCancelarAlias";
            btnCancelarAlias.Size = new Size(108, 30);
            btnCancelarAlias.TabIndex = 12;
            btnCancelarAlias.Text = "Cancelar";
            btnCancelarAlias.UseVisualStyleBackColor = true;
            btnCancelarAlias.Click += btnCancelarAlias_Click;
            // 
            // btnAceptarAlias
            // 
            btnAceptarAlias.Location = new Point(37, 42);
            btnAceptarAlias.Margin = new Padding(2);
            btnAceptarAlias.Name = "btnAceptarAlias";
            btnAceptarAlias.Size = new Size(104, 30);
            btnAceptarAlias.TabIndex = 1;
            btnAceptarAlias.Text = "Aceptar";
            btnAceptarAlias.UseVisualStyleBackColor = true;
            btnAceptarAlias.Click += btnAceptarAlias_Click;
            // 
            // txtCambiarAlias
            // 
            txtCambiarAlias.Location = new Point(37, 8);
            txtCambiarAlias.Margin = new Padding(2);
            txtCambiarAlias.Name = "txtCambiarAlias";
            txtCambiarAlias.Size = new Size(248, 26);
            txtCambiarAlias.TabIndex = 0;
            // 
            // btnCambiarAlias
            // 
            btnCambiarAlias.Location = new Point(608, 35);
            btnCambiarAlias.Margin = new Padding(2);
            btnCambiarAlias.Name = "btnCambiarAlias";
            btnCambiarAlias.Size = new Size(228, 31);
            btnCambiarAlias.TabIndex = 2;
            btnCambiarAlias.Text = "Cambiar Alias";
            btnCambiarAlias.UseVisualStyleBackColor = true;
            btnCambiarAlias.Click += btnCambiarAlias_Click;
            // 
            // btnChangePassFormPerfil
            // 
            btnChangePassFormPerfil.Location = new Point(318, 35);
            btnChangePassFormPerfil.Margin = new Padding(2);
            btnChangePassFormPerfil.Name = "btnChangePassFormPerfil";
            btnChangePassFormPerfil.Size = new Size(239, 31);
            btnChangePassFormPerfil.TabIndex = 1;
            btnChangePassFormPerfil.Text = "Cambiar Contraseña";
            btnChangePassFormPerfil.UseVisualStyleBackColor = true;
            btnChangePassFormPerfil.Click += btnChangePassFormPerfil_Click;
            // 
            // btnChangeMail
            // 
            btnChangeMail.Location = new Point(12, 35);
            btnChangeMail.Margin = new Padding(2);
            btnChangeMail.Name = "btnChangeMail";
            btnChangeMail.Size = new Size(272, 31);
            btnChangeMail.TabIndex = 0;
            btnChangeMail.Text = "Cambiar Mail";
            btnChangeMail.UseVisualStyleBackColor = true;
            btnChangeMail.Click += btnChangeMail_Click;
            // 
            // btnCopyAlias
            // 
            btnCopyAlias.BackColor = Color.FromArgb(255, 128, 0);
            btnCopyAlias.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyAlias.ForeColor = SystemColors.ButtonHighlight;
            btnCopyAlias.Location = new Point(678, 299);
            btnCopyAlias.Margin = new Padding(2);
            btnCopyAlias.Name = "btnCopyAlias";
            btnCopyAlias.Size = new Size(161, 32);
            btnCopyAlias.TabIndex = 11;
            btnCopyAlias.Text = "COPIAR ALIAS";
            btnCopyAlias.UseVisualStyleBackColor = false;
            btnCopyAlias.Click += btnCopyAlias_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 236, 238);
            ClientSize = new Size(887, 426);
            Controls.Add(btnCopyAlias);
            Controls.Add(gbPersonalData);
            Controls.Add(btnCopy);
            Controls.Add(LabelContenidoCuil);
            Controls.Add(LabelContenidoAlias);
            Controls.Add(LabelContenidoCbu);
            Controls.Add(LabelAlias);
            Controls.Add(LabelCuil);
            Controls.Add(LabelCbu);
            Controls.Add(LabelPerfil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfile";
            Load += FormProfile_Load;
            gbPersonalData.ResumeLayout(false);
            panelCambiarContra.ResumeLayout(false);
            panelCambiarContra.PerformLayout();
            panelAceptarMail.ResumeLayout(false);
            panelAceptarMail.PerformLayout();
            panelCambiarAlias.ResumeLayout(false);
            panelCambiarAlias.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPerfil;
        private Label LabelCbu;
        private Label LabelCuil;
        private Label LabelAlias;
        private Label LabelContenidoCbu;
        private Label LabelContenidoAlias;
        private Label LabelContenidoCuil;
        private Button btnCopy;
        private GroupBox gbPersonalData;
        private Button btnChangePassFormPerfil;
        private Button btnChangeMail;
        private Button btnCopyAlias;
        private Button btnCambiarAlias;
        private Panel panelCambiarAlias;
        private Button btnCancelarAlias;
        private Button btnAceptarAlias;
        private TextBox txtCambiarAlias;
        private Panel panelAceptarMail;
        private Button btnCancelarMail;
        private Button btnAceptarMail;
        private TextBox txtCambiarMail;
        private Panel panelCambiarContra;
        private Button btnCancelarContra;
        private Button btnAceptarContra;
        private TextBox txtCambiarContra;
    }
}