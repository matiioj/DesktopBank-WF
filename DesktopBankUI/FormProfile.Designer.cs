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
            // 
            // LabelCbu
            // 
            LabelCbu.AutoSize = true;
            LabelCbu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCbu.Location = new Point(13, 248);
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
            LabelCuil.Location = new Point(13, 393);
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
            LabelAlias.Location = new Point(13, 318);
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
            LabelContenidoCbu.Location = new Point(296, 242);
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
            LabelContenidoAlias.Location = new Point(296, 308);
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
            LabelContenidoCuil.Location = new Point(296, 393);
            LabelContenidoCuil.Margin = new Padding(4, 0, 4, 0);
            LabelContenidoCuil.Name = "LabelContenidoCuil";
            LabelContenidoCuil.Size = new Size(48, 65);
            LabelContenidoCuil.TabIndex = 8;
            LabelContenidoCuil.Text = "_";
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1120, 685);
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
    }
}