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
            button1 = new Button();
            txtBoxClave = new TextBox();
            txtBoxClaveVerificacion = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(115, 443);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
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
            // button2
            // 
            button2.Location = new Point(302, 443);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxClave);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtBoxClaveVerificacion);
            groupBox1.Controls.Add(button1);
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

        private Button button1;
        private TextBox txtBoxClave;
        private TextBox txtBoxClaveVerificacion;
        private Button button2;
        private GroupBox groupBox1;
    }
}