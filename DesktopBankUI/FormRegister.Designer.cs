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
            TxtPassword = new TextBox();
            labelContra = new Label();
            TxtUser = new TextBox();
            TxtMail = new TextBox();
            TxtSurname = new TextBox();
            TxtName = new TextBox();
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
            boxDatos.Controls.Add(TxtPassword);
            boxDatos.Controls.Add(labelContra);
            boxDatos.Controls.Add(TxtUser);
            boxDatos.Controls.Add(TxtMail);
            boxDatos.Controls.Add(TxtSurname);
            boxDatos.Controls.Add(TxtName);
            boxDatos.Controls.Add(labelUsuario);
            boxDatos.Controls.Add(labelCorreo);
            boxDatos.Controls.Add(labelApellido);
            boxDatos.Controls.Add(labelNombre);
            boxDatos.Location = new Point(17, 93);
            boxDatos.Margin = new Padding(4, 5, 4, 5);
            boxDatos.Name = "boxDatos";
            boxDatos.Padding = new Padding(4, 5, 4, 5);
            boxDatos.Size = new Size(529, 473);
            boxDatos.TabIndex = 0;
            boxDatos.TabStop = false;
            boxDatos.Enter += boxDatos_Enter;
            // 
            // TxtCuil
            // 
            TxtCuil.Location = new Point(123, 255);
            TxtCuil.Margin = new Padding(4, 5, 4, 5);
            TxtCuil.Name = "TxtCuil";
            TxtCuil.Size = new Size(377, 31);
            TxtCuil.TabIndex = 11;
            // 
            // labelCuil
            // 
            labelCuil.AutoSize = true;
            labelCuil.Location = new Point(70, 261);
            labelCuil.Margin = new Padding(4, 0, 4, 0);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(45, 25);
            labelCuil.TabIndex = 10;
            labelCuil.Text = "Cuil:";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(123, 384);
            TxtPassword.Margin = new Padding(4, 5, 4, 5);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(377, 31);
            TxtPassword.TabIndex = 9;
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Location = new Point(14, 384);
            labelContra.Margin = new Padding(4, 0, 4, 0);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(105, 25);
            labelContra.TabIndex = 8;
            labelContra.Text = "Contraseña:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(123, 318);
            TxtUser.Margin = new Padding(4, 5, 4, 5);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(377, 31);
            TxtUser.TabIndex = 7;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(119, 196);
            TxtMail.Margin = new Padding(4, 5, 4, 5);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(377, 31);
            TxtMail.TabIndex = 6;
            // 
            // TxtSurname
            // 
            TxtSurname.Location = new Point(123, 136);
            TxtSurname.Margin = new Padding(4, 5, 4, 5);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(377, 31);
            TxtSurname.TabIndex = 5;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(123, 66);
            TxtName.Margin = new Padding(4, 5, 4, 5);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(377, 31);
            TxtName.TabIndex = 4;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(39, 324);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(76, 25);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(45, 202);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(70, 25);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "Correo:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(37, 142);
            labelApellido.Margin = new Padding(4, 0, 4, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(82, 25);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(37, 72);
            labelNombre.Margin = new Padding(4, 0, 4, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(82, 25);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.Image = (Image)resources.GetObject("BtnCancelar.Image");
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(317, 651);
            BtnCancelar.Margin = new Padding(4, 5, 4, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 48);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "Limpiar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Location = new Point(87, 651);
            BtnAceptar.Margin = new Padding(4, 5, 4, 5);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(147, 48);
            BtnAceptar.TabIndex = 2;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 762);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(boxDatos);
            Margin = new Padding(4, 5, 4, 5);
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
        private TextBox TxtMail;
        private TextBox TxtSurname;
        private TextBox TxtName;
        private Label labelUsuario;
        private Label labelCorreo;
        private Label labelApellido;
        private Label labelNombre;
        private Button BtnAceptar;
        private Label labelContra;
        private TextBox TxtCuil;
        private Label labelCuil;
        private TextBox TxtPassword;
    }
}