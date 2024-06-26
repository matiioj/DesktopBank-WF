﻿namespace DesktopBankUI
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
            LabelPerfil.Location = new Point(13, 22);
            LabelPerfil.Margin = new Padding(4, 0, 4, 0);
            LabelPerfil.Name = "LabelPerfil";
            LabelPerfil.Size = new Size(134, 65);
            LabelPerfil.TabIndex = 0;
            LabelPerfil.Text = "Perfil";
            LabelPerfil.Click += LabelPerfil_Click;
            // 
            // LabelCbu
            // 
            LabelCbu.AutoSize = true;
            LabelCbu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCbu.Location = new Point(39, 425);
            LabelCbu.Margin = new Padding(4, 0, 4, 0);
            LabelCbu.Name = "LabelCbu";
            LabelCbu.Size = new Size(119, 65);
            LabelCbu.TabIndex = 1;
            LabelCbu.Text = "CBU";
            // 
            // LabelCuil
            // 
            LabelCuil.AutoSize = true;
            LabelCuil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCuil.Location = new Point(39, 570);
            LabelCuil.Margin = new Padding(4, 0, 4, 0);
            LabelCuil.Name = "LabelCuil";
            LabelCuil.Size = new Size(127, 65);
            LabelCuil.TabIndex = 2;
            LabelCuil.Text = "CUIL";
            // 
            // LabelAlias
            // 
            LabelAlias.AutoSize = true;
            LabelAlias.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAlias.Location = new Point(39, 495);
            LabelAlias.Margin = new Padding(4, 0, 4, 0);
            LabelAlias.Name = "LabelAlias";
            LabelAlias.Size = new Size(127, 65);
            LabelAlias.TabIndex = 4;
            LabelAlias.Text = "Alias";
            // 
            // LabelContenidoCbu
            // 
            LabelContenidoCbu.AutoSize = true;
            LabelContenidoCbu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCbu.Location = new Point(232, 425);
            LabelContenidoCbu.Margin = new Padding(4, 0, 4, 0);
            LabelContenidoCbu.Name = "LabelContenidoCbu";
            LabelContenidoCbu.Size = new Size(48, 65);
            LabelContenidoCbu.TabIndex = 5;
            LabelContenidoCbu.Text = "_";
            LabelContenidoCbu.Click += LabelContenidoCbu_Click;
            // 
            // LabelContenidoAlias
            // 
            LabelContenidoAlias.AutoSize = true;
            LabelContenidoAlias.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoAlias.Location = new Point(232, 491);
            LabelContenidoAlias.Margin = new Padding(4, 0, 4, 0);
            LabelContenidoAlias.Name = "LabelContenidoAlias";
            LabelContenidoAlias.Size = new Size(48, 65);
            LabelContenidoAlias.TabIndex = 6;
            LabelContenidoAlias.Text = "_";
            // 
            // LabelContenidoCuil
            // 
            LabelContenidoCuil.AutoSize = true;
            LabelContenidoCuil.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCuil.Location = new Point(232, 576);
            LabelContenidoCuil.Margin = new Padding(4, 0, 4, 0);
            LabelContenidoCuil.Name = "LabelContenidoCuil";
            LabelContenidoCuil.Size = new Size(48, 65);
            LabelContenidoCuil.TabIndex = 8;
            LabelContenidoCuil.Text = "_";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(255, 128, 0);
            btnCopy.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopy.ForeColor = SystemColors.ButtonHighlight;
            btnCopy.Location = new Point(992, 425);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(230, 54);
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
            gbPersonalData.Location = new Point(50, 113);
            gbPersonalData.Name = "gbPersonalData";
            gbPersonalData.Size = new Size(1172, 248);
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
            panelCambiarContra.Location = new Point(454, 129);
            panelCambiarContra.Name = "panelCambiarContra";
            panelCambiarContra.Size = new Size(285, 113);
            panelCambiarContra.TabIndex = 5;
            panelCambiarContra.Visible = false;
            // 
            // btnCancelarContra
            // 
            btnCancelarContra.Location = new Point(151, 54);
            btnCancelarContra.Name = "btnCancelarContra";
            btnCancelarContra.Size = new Size(120, 34);
            btnCancelarContra.TabIndex = 12;
            btnCancelarContra.Text = "Cancelar";
            btnCancelarContra.UseVisualStyleBackColor = true;
            btnCancelarContra.Click += btnCancelarContra_Click;
            // 
            // btnAceptarContra
            // 
            btnAceptarContra.Location = new Point(15, 54);
            btnAceptarContra.Name = "btnAceptarContra";
            btnAceptarContra.Size = new Size(119, 34);
            btnAceptarContra.TabIndex = 1;
            btnAceptarContra.Text = "Aceptar";
            btnAceptarContra.UseVisualStyleBackColor = true;
            btnAceptarContra.Click += btnAceptarContra_Click;
            // 
            // txtCambiarContra
            // 
            txtCambiarContra.Location = new Point(15, 13);
            txtCambiarContra.Name = "txtCambiarContra";
            txtCambiarContra.Size = new Size(256, 35);
            txtCambiarContra.TabIndex = 0;
            txtCambiarContra.TextChanged += txtCambiarContra_TextChanged;
            // 
            // panelAceptarMail
            // 
            panelAceptarMail.Controls.Add(btnCancelarMail);
            panelAceptarMail.Controls.Add(btnAceptarMail);
            panelAceptarMail.Controls.Add(txtCambiarMail);
            panelAceptarMail.Location = new Point(17, 129);
            panelAceptarMail.Name = "panelAceptarMail";
            panelAceptarMail.Size = new Size(402, 113);
            panelAceptarMail.TabIndex = 4;
            panelAceptarMail.Visible = false;
            // 
            // btnCancelarMail
            // 
            btnCancelarMail.Location = new Point(209, 54);
            btnCancelarMail.Name = "btnCancelarMail";
            btnCancelarMail.Size = new Size(176, 34);
            btnCancelarMail.TabIndex = 12;
            btnCancelarMail.Text = "Cancelar";
            btnCancelarMail.UseVisualStyleBackColor = true;
            btnCancelarMail.Click += btnCancelarMail_Click;
            // 
            // btnAceptarMail
            // 
            btnAceptarMail.Location = new Point(14, 54);
            btnAceptarMail.Name = "btnAceptarMail";
            btnAceptarMail.Size = new Size(176, 34);
            btnAceptarMail.TabIndex = 1;
            btnAceptarMail.Text = "Aceptar";
            btnAceptarMail.UseVisualStyleBackColor = true;
            btnAceptarMail.Click += btnAceptarMail_Click;
            // 
            // txtCambiarMail
            // 
            txtCambiarMail.Location = new Point(14, 13);
            txtCambiarMail.Name = "txtCambiarMail";
            txtCambiarMail.Size = new Size(371, 35);
            txtCambiarMail.TabIndex = 0;
            // 
            // panelCambiarAlias
            // 
            panelCambiarAlias.Controls.Add(btnCancelarAlias);
            panelCambiarAlias.Controls.Add(btnAceptarAlias);
            panelCambiarAlias.Controls.Add(txtCambiarAlias);
            panelCambiarAlias.Location = new Point(771, 135);
            panelCambiarAlias.Name = "panelCambiarAlias";
            panelCambiarAlias.Size = new Size(401, 113);
            panelCambiarAlias.TabIndex = 3;
            panelCambiarAlias.Visible = false;
            panelCambiarAlias.Paint += panelCambiarAlias_Paint;
            // 
            // btnCancelarAlias
            // 
            btnCancelarAlias.Location = new Point(209, 54);
            btnCancelarAlias.Name = "btnCancelarAlias";
            btnCancelarAlias.Size = new Size(154, 34);
            btnCancelarAlias.TabIndex = 12;
            btnCancelarAlias.Text = "Cancelar";
            btnCancelarAlias.UseVisualStyleBackColor = true;
            btnCancelarAlias.Click += btnCancelarAlias_Click;
            // 
            // btnAceptarAlias
            // 
            btnAceptarAlias.Location = new Point(28, 54);
            btnAceptarAlias.Name = "btnAceptarAlias";
            btnAceptarAlias.Size = new Size(148, 34);
            btnAceptarAlias.TabIndex = 1;
            btnAceptarAlias.Text = "Aceptar";
            btnAceptarAlias.UseVisualStyleBackColor = true;
            btnAceptarAlias.Click += btnAceptarAlias_Click;
            // 
            // txtCambiarAlias
            // 
            txtCambiarAlias.Location = new Point(28, 7);
            txtCambiarAlias.Name = "txtCambiarAlias";
            txtCambiarAlias.Size = new Size(335, 35);
            txtCambiarAlias.TabIndex = 0;
            // 
            // btnCambiarAlias
            // 
            btnCambiarAlias.Location = new Point(799, 59);
            btnCambiarAlias.Name = "btnCambiarAlias";
            btnCambiarAlias.Size = new Size(326, 51);
            btnCambiarAlias.TabIndex = 2;
            btnCambiarAlias.Text = "Cambiar Alias";
            btnCambiarAlias.UseVisualStyleBackColor = true;
            btnCambiarAlias.Click += btnCambiarAlias_Click;
            // 
            // btnChangePassFormPerfil
            // 
            btnChangePassFormPerfil.Location = new Point(465, 59);
            btnChangePassFormPerfil.Name = "btnChangePassFormPerfil";
            btnChangePassFormPerfil.Size = new Size(263, 51);
            btnChangePassFormPerfil.TabIndex = 1;
            btnChangePassFormPerfil.Text = "Cambiar Contraseña";
            btnChangePassFormPerfil.UseVisualStyleBackColor = true;
            btnChangePassFormPerfil.Click += btnChangePassFormPerfil_Click;
            // 
            // btnChangeMail
            // 
            btnChangeMail.Location = new Point(17, 59);
            btnChangeMail.Name = "btnChangeMail";
            btnChangeMail.Size = new Size(388, 51);
            btnChangeMail.TabIndex = 0;
            btnChangeMail.Text = "Cambair Mail";
            btnChangeMail.UseVisualStyleBackColor = true;
            btnChangeMail.Click += btnChangeMail_Click;
            // 
            // btnCopyAlias
            // 
            btnCopyAlias.BackColor = Color.FromArgb(255, 128, 0);
            btnCopyAlias.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyAlias.ForeColor = SystemColors.ButtonHighlight;
            btnCopyAlias.Location = new Point(992, 491);
            btnCopyAlias.Name = "btnCopyAlias";
            btnCopyAlias.Size = new Size(230, 54);
            btnCopyAlias.TabIndex = 11;
            btnCopyAlias.Text = "COPIAR ALIAS";
            btnCopyAlias.UseVisualStyleBackColor = false;
            btnCopyAlias.Click += btnCopyAlias_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 236, 238);
            ClientSize = new Size(1267, 710);
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
            Margin = new Padding(4, 5, 4, 5);
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