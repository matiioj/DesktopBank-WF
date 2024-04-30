namespace StudentSystem.WindowsFormsCliente
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            groupBox1 = new GroupBox();
            TxtUser = new TextBox();
            TxtCorreo = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtUser);
            groupBox1.Controls.Add(TxtCorreo);
            groupBox1.Controls.Add(TxtApellido);
            groupBox1.Controls.Add(TxtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del usuario";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(82, 123);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(265, 23);
            TxtUser.TabIndex = 7;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(82, 94);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(265, 23);
            TxtCorreo.TabIndex = 6;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(82, 65);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(265, 23);
            TxtApellido.TabIndex = 5;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(82, 36);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(265, 23);
            TxtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 126);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(284, 214);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(128, 29);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(193, 217);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(472, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmRegistrese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 258);
            Controls.Add(pictureBox1);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(groupBox1);
            Name = "FrmRegistrese";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrese";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnCancelar;
        private TextBox TxtUser;
        private TextBox TxtCorreo;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnAceptar;
        private PictureBox pictureBox1;
    }
}