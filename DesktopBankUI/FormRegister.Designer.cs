namespace StudentSystem.WindowsFormsCliente
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            boxDatos = new GroupBox();
            TxtCuil = new TextBox();
            labelCuil = new Label();
            TxtContra = new TextBox();
            labelContra = new Label();
            TxtUser = new TextBox();
            TxtCorreo = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            labelUsuario = new Label();
            labelCorreo = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            BtnCancelar = new Button();
            BtnAceptar = new Button();
            boxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // boxDatos
            // 
            boxDatos.Controls.Add(TxtCuil);
            boxDatos.Controls.Add(labelCuil);
            boxDatos.Controls.Add(TxtContra);
            boxDatos.Controls.Add(labelContra);
            boxDatos.Controls.Add(TxtUser);
            boxDatos.Controls.Add(TxtCorreo);
            boxDatos.Controls.Add(TxtApellido);
            boxDatos.Controls.Add(TxtNombre);
            boxDatos.Controls.Add(labelUsuario);
            boxDatos.Controls.Add(labelCorreo);
            boxDatos.Controls.Add(labelApellido);
            boxDatos.Controls.Add(labelNombre);
            boxDatos.Location = new Point(12, 56);
            boxDatos.Name = "boxDatos";
            boxDatos.Size = new Size(370, 196);
            boxDatos.TabIndex = 0;
            boxDatos.TabStop = false;
            // 
            // TxtCuil
            // 
            TxtCuil.Location = new Point(86, 100);
            TxtCuil.Name = "TxtCuil";
            TxtCuil.Size = new Size(265, 23);
            TxtCuil.TabIndex = 11;
            // 
            // labelCuil
            // 
            labelCuil.AutoSize = true;
            labelCuil.Location = new Point(49, 108);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(31, 15);
            labelCuil.TabIndex = 10;
            labelCuil.Text = "Cuil:";
            // 
            // TxtContra
            // 
            TxtContra.Location = new Point(86, 152);
            TxtContra.Name = "TxtContra";
            TxtContra.Size = new Size(265, 23);
            TxtContra.TabIndex = 9;
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Location = new Point(10, 160);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(70, 15);
            labelContra.TabIndex = 8;
            labelContra.Text = "Contraseña:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(86, 126);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(265, 23);
            TxtUser.TabIndex = 7;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(86, 73);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(265, 23);
            TxtCorreo.TabIndex = 6;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(86, 47);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(265, 23);
            TxtApellido.TabIndex = 5;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(86, 21);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(265, 23);
            TxtNombre.TabIndex = 4;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(30, 134);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(34, 81);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(46, 15);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "Correo:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(26, 55);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(26, 29);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(214, 272);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(107, 29);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Limpiar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Location = new Point(61, 272);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(103, 29);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 395);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(boxDatos);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrese";
            boxDatos.ResumeLayout(false);
            boxDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxDatos;
        private Button BtnCancelar;
        private TextBox TxtUser;
        private TextBox TxtCorreo;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Label labelUsuario;
        private Label labelCorreo;
        private Label labelApellido;
        private Label labelNombre;
        private Button BtnAceptar;
        private Label labelContra;
        private TextBox TxtCuil;
        private Label labelCuil;
        private TextBox TxtContra;
    }
}