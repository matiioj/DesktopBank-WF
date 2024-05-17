namespace DesktopBankUI
{
    partial class FormPasswordUpdate
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
            btnConfirmar = new Button();
            txtBoxClave = new TextBox();
            txtBoxClaveVerificacion = new TextBox();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(115, 443);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(112, 34);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(60, 137);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.Size = new Size(433, 31);
            txtBoxClave.TabIndex = 2;
            txtBoxClave.Text = "Ingrese su nueva clave";
            txtBoxClave.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxClaveVerificacion
            // 
            txtBoxClaveVerificacion.Location = new Point(60, 292);
            txtBoxClaveVerificacion.Name = "txtBoxClaveVerificacion";
            txtBoxClaveVerificacion.Size = new Size(433, 31);
            txtBoxClaveVerificacion.TabIndex = 3;
            txtBoxClaveVerificacion.Text = "Ingrese nuevamente su clave";
            txtBoxClaveVerificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(302, 443);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxClave);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtBoxClaveVerificacion);
            groupBox1.Controls.Add(btnConfirmar);
            groupBox1.Location = new Point(68, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 536);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cambio de clave";
            // 
            // FormPasswordUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(666, 651);
            Controls.Add(groupBox1);
            Name = "FormPasswordUpdate";
            Text = "FormPasswordUpdate";
            Load += FormPasswordUpdate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtBoxClave;
        private TextBox txtBoxClaveVerificacion;
        private Button btnCancelar;
        private GroupBox groupBox1;
    }
}