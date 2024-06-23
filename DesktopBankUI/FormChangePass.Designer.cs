namespace DesktopBankUI
{
    partial class FormChangePass
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
            etqUserChP = new Label();
            etqCorreoChP = new Label();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnCancelarChP = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(166, 371);
            button1.Name = "button1";
            button1.Size = new Size(166, 49);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // etqUserChP
            // 
            etqUserChP.AutoSize = true;
            etqUserChP.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            etqUserChP.Location = new Point(29, 56);
            etqUserChP.Name = "etqUserChP";
            etqUserChP.Size = new Size(87, 26);
            etqUserChP.TabIndex = 1;
            etqUserChP.Text = "Usuario:";
            // 
            // etqCorreoChP
            // 
            etqCorreoChP.AutoSize = true;
            etqCorreoChP.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            etqCorreoChP.Location = new Point(29, 181);
            etqCorreoChP.Name = "etqCorreoChP";
            etqCorreoChP.Size = new Size(80, 26);
            etqCorreoChP.TabIndex = 2;
            etqCorreoChP.Text = "Correo:";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(etqUserChP);
            panel1.Controls.Add(etqCorreoChP);
            panel1.Location = new Point(51, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 273);
            panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(535, 31);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(535, 31);
            textBox1.TabIndex = 3;
            // 
            // btnCancelarChP
            // 
            btnCancelarChP.ForeColor = Color.Black;
            btnCancelarChP.Location = new Point(467, 371);
            btnCancelarChP.Name = "btnCancelarChP";
            btnCancelarChP.Size = new Size(166, 49);
            btnCancelarChP.TabIndex = 4;
            btnCancelarChP.Text = "Cancelar";
            btnCancelarChP.UseVisualStyleBackColor = true;
            btnCancelarChP.Click += btnCancelarChP_Click;
            // 
            // FormChangePass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(844, 484);
            Controls.Add(btnCancelarChP);
            Controls.Add(panel1);
            Controls.Add(button1);
            ForeColor = Color.White;
            Name = "FormChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangePass";
            Load += FormChangePass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label etqUserChP;
        private Label etqCorreoChP;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnCancelarChP;
    }
}