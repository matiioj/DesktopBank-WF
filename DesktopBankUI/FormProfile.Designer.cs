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
            LabelNumeroDeCuenta = new Label();
            LabelAlias = new Label();
            LabelContenidoCbu = new Label();
            LabelContenidoAlias = new Label();
            LabelContenidoNumCuenta = new Label();
            LabelContenidoCuil = new Label();
            SuspendLayout();
            // 
            // LabelPerfil
            // 
            LabelPerfil.AutoSize = true;
            LabelPerfil.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPerfil.Location = new Point(12, 9);
            LabelPerfil.Name = "LabelPerfil";
            LabelPerfil.Size = new Size(61, 30);
            LabelPerfil.TabIndex = 0;
            LabelPerfil.Text = "Perfil";
            // 
            // LabelCbu
            // 
            LabelCbu.AutoSize = true;
            LabelCbu.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCbu.Location = new Point(12, 56);
            LabelCbu.Name = "LabelCbu";
            LabelCbu.Size = new Size(45, 25);
            LabelCbu.TabIndex = 1;
            LabelCbu.Text = "CBU";
            // 
            // LabelCuil
            // 
            LabelCuil.AutoSize = true;
            LabelCuil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCuil.Location = new Point(12, 155);
            LabelCuil.Name = "LabelCuil";
            LabelCuil.Size = new Size(48, 25);
            LabelCuil.TabIndex = 2;
            LabelCuil.Text = "CUIL";
            // 
            // LabelNumeroDeCuenta
            // 
            LabelNumeroDeCuenta.AutoSize = true;
            LabelNumeroDeCuenta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNumeroDeCuenta.Location = new Point(12, 120);
            LabelNumeroDeCuenta.Name = "LabelNumeroDeCuenta";
            LabelNumeroDeCuenta.Size = new Size(159, 25);
            LabelNumeroDeCuenta.TabIndex = 3;
            LabelNumeroDeCuenta.Text = "Numero de cuenta";
            // 
            // LabelAlias
            // 
            LabelAlias.AutoSize = true;
            LabelAlias.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAlias.Location = new Point(12, 86);
            LabelAlias.Name = "LabelAlias";
            LabelAlias.Size = new Size(49, 25);
            LabelAlias.TabIndex = 4;
            LabelAlias.Text = "Alias";
            // 
            // LabelContenidoCbu
            // 
            LabelContenidoCbu.AutoSize = true;
            LabelContenidoCbu.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCbu.Location = new Point(209, 56);
            LabelContenidoCbu.Name = "LabelContenidoCbu";
            LabelContenidoCbu.Size = new Size(19, 25);
            LabelContenidoCbu.TabIndex = 5;
            LabelContenidoCbu.Text = "_";
            // 
            // LabelContenidoAlias
            // 
            LabelContenidoAlias.AutoSize = true;
            LabelContenidoAlias.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoAlias.Location = new Point(209, 86);
            LabelContenidoAlias.Name = "LabelContenidoAlias";
            LabelContenidoAlias.Size = new Size(19, 25);
            LabelContenidoAlias.TabIndex = 6;
            LabelContenidoAlias.Text = "_";
            // 
            // LabelContenidoNumCuenta
            // 
            LabelContenidoNumCuenta.AutoSize = true;
            LabelContenidoNumCuenta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoNumCuenta.Location = new Point(209, 120);
            LabelContenidoNumCuenta.Name = "LabelContenidoNumCuenta";
            LabelContenidoNumCuenta.Size = new Size(19, 25);
            LabelContenidoNumCuenta.TabIndex = 7;
            LabelContenidoNumCuenta.Text = "_";
            // 
            // LabelContenidoCuil
            // 
            LabelContenidoCuil.AutoSize = true;
            LabelContenidoCuil.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LabelContenidoCuil.Location = new Point(209, 155);
            LabelContenidoCuil.Name = "LabelContenidoCuil";
            LabelContenidoCuil.Size = new Size(19, 25);
            LabelContenidoCuil.TabIndex = 8;
            LabelContenidoCuil.Text = "_";
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(LabelContenidoCuil);
            Controls.Add(LabelContenidoNumCuenta);
            Controls.Add(LabelContenidoAlias);
            Controls.Add(LabelContenidoCbu);
            Controls.Add(LabelAlias);
            Controls.Add(LabelNumeroDeCuenta);
            Controls.Add(LabelCuil);
            Controls.Add(LabelCbu);
            Controls.Add(LabelPerfil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfile";
            Text = "FormProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelPerfil;
        private Label LabelCbu;
        private Label LabelCuil;
        private Label LabelNumeroDeCuenta;
        private Label LabelAlias;
        private Label LabelContenidoCbu;
        private Label LabelContenidoAlias;
        private Label LabelContenidoNumCuenta;
        private Label LabelContenidoCuil;
    }
}