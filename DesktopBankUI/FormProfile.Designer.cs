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
            btnChangePassFormPerfil = new Button();
            btnChangeMail = new Button();
            btnCopyAlias = new Button();
            button1 = new Button();
            gbPersonalData.SuspendLayout();
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
            btnCopy.Location = new Point(771, 425);
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
            gbPersonalData.Controls.Add(button1);
            gbPersonalData.Controls.Add(btnChangePassFormPerfil);
            gbPersonalData.Controls.Add(btnChangeMail);
            gbPersonalData.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbPersonalData.Location = new Point(50, 113);
            gbPersonalData.Name = "gbPersonalData";
            gbPersonalData.Size = new Size(991, 151);
            gbPersonalData.TabIndex = 10;
            gbPersonalData.TabStop = false;
            gbPersonalData.Text = "Datos Personales";
            // 
            // btnChangePassFormPerfil
            // 
            btnChangePassFormPerfil.Location = new Point(340, 59);
            btnChangePassFormPerfil.Name = "btnChangePassFormPerfil";
            btnChangePassFormPerfil.Size = new Size(305, 51);
            btnChangePassFormPerfil.TabIndex = 1;
            btnChangePassFormPerfil.Text = "Cambiar Contraseña";
            btnChangePassFormPerfil.UseVisualStyleBackColor = true;
            // 
            // btnChangeMail
            // 
            btnChangeMail.Location = new Point(26, 59);
            btnChangeMail.Name = "btnChangeMail";
            btnChangeMail.Size = new Size(281, 51);
            btnChangeMail.TabIndex = 0;
            btnChangeMail.Text = "Cambair Mail";
            btnChangeMail.UseVisualStyleBackColor = true;
            // 
            // btnCopyAlias
            // 
            btnCopyAlias.BackColor = Color.FromArgb(255, 128, 0);
            btnCopyAlias.Font = new Font("Cascadia Code", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCopyAlias.ForeColor = SystemColors.ButtonHighlight;
            btnCopyAlias.Location = new Point(771, 495);
            btnCopyAlias.Name = "btnCopyAlias";
            btnCopyAlias.Size = new Size(230, 54);
            btnCopyAlias.TabIndex = 11;
            btnCopyAlias.Text = "COPIAR ALIAS";
            btnCopyAlias.UseVisualStyleBackColor = false;
            btnCopyAlias.Click += btnCopyAlias_Click;
            // 
            // button1
            // 
            button1.Location = new Point(681, 59);
            button1.Name = "button1";
            button1.Size = new Size(282, 51);
            button1.TabIndex = 2;
            button1.Text = "Cambiar Alias";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 236, 238);
            ClientSize = new Size(1120, 685);
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
        private Button button1;
    }
}