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
            labelTenesCuenta = new Label();
            botonLogin = new Button();
            LabelMoneda = new Label();
            ComboBoxCurrencies = new ComboBox();
            boxDatos.SuspendLayout();
            SuspendLayout();
            // 
            // boxDatos
            // 
            boxDatos.Controls.Add(ComboBoxCurrencies);
            boxDatos.Controls.Add(LabelMoneda);
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
            boxDatos.Location = new Point(12, 39);
            boxDatos.Name = "boxDatos";
            boxDatos.Size = new Size(370, 221);
            boxDatos.TabIndex = 0;
            boxDatos.TabStop = false;
            // 
            // TxtCuil
            // 
            TxtCuil.Location = new Point(86, 100);
            TxtCuil.Name = "TxtCuil";
            TxtCuil.Size = new Size(265, 23);
            TxtCuil.TabIndex = 4;
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
            TxtContra.TabIndex = 6;
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Location = new Point(10, 157);
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
            TxtUser.TabIndex = 5;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(86, 73);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(265, 23);
            TxtCorreo.TabIndex = 3;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(86, 47);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(265, 23);
            TxtApellido.TabIndex = 2;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(86, 21);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(265, 23);
            TxtNombre.TabIndex = 1;
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
            BtnCancelar.Location = new Point(214, 280);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(107, 29);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Limpiar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Location = new Point(61, 280);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(103, 29);
            BtnAceptar.TabIndex = 7;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // labelTenesCuenta
            // 
            labelTenesCuenta.AutoSize = true;
            labelTenesCuenta.Location = new Point(35, 325);
            labelTenesCuenta.Name = "labelTenesCuenta";
            labelTenesCuenta.Size = new Size(122, 15);
            labelTenesCuenta.TabIndex = 3;
            labelTenesCuenta.Text = "¿Ya tenes una cuenta?";
            // 
            // botonLogin
            // 
            botonLogin.Cursor = Cursors.Hand;
            botonLogin.Location = new Point(42, 352);
            botonLogin.Name = "botonLogin";
            botonLogin.Size = new Size(75, 23);
            botonLogin.TabIndex = 9;
            botonLogin.Text = "Login";
            botonLogin.UseVisualStyleBackColor = true;
            botonLogin.Click += botonLogin_Click;
            // 
            // LabelMoneda
            // 
            LabelMoneda.AutoSize = true;
            LabelMoneda.Location = new Point(26, 181);
            LabelMoneda.Name = "LabelMoneda";
            LabelMoneda.Size = new Size(54, 15);
            LabelMoneda.TabIndex = 11;
            LabelMoneda.Text = "Moneda:";
            // 
            // ComboBoxCurrencies
            // 
            ComboBoxCurrencies.FormattingEnabled = true;
            ComboBoxCurrencies.Location = new Point(86, 178);
            ComboBoxCurrencies.Name = "ComboBoxCurrencies";
            ComboBoxCurrencies.Size = new Size(265, 23);
            ComboBoxCurrencies.TabIndex = 12;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 407);
            Controls.Add(botonLogin);
            Controls.Add(labelTenesCuenta);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(boxDatos);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrese";
            boxDatos.ResumeLayout(false);
            boxDatos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelTenesCuenta;
        private Button botonLogin;
        private ComboBox ComboBoxCurrencies;
        private Label LabelMoneda;
    }
}