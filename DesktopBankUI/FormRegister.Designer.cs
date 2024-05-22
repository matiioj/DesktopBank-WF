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
            ComboBoxCurrencies = new ComboBox();
            LabelMoneda = new Label();
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
            boxDatos.Location = new Point(17, 65);
            boxDatos.Margin = new Padding(4, 5, 4, 5);
            boxDatos.Name = "boxDatos";
            boxDatos.Padding = new Padding(4, 5, 4, 5);
            boxDatos.Size = new Size(529, 368);
            boxDatos.TabIndex = 0;
            boxDatos.TabStop = false;
            // 
            // ComboBoxCurrencies
            // 
            ComboBoxCurrencies.FormattingEnabled = true;
            ComboBoxCurrencies.Location = new Point(123, 297);
            ComboBoxCurrencies.Margin = new Padding(4, 5, 4, 5);
            ComboBoxCurrencies.Name = "ComboBoxCurrencies";
            ComboBoxCurrencies.Size = new Size(377, 33);
            ComboBoxCurrencies.TabIndex = 12;
            // 
            // LabelMoneda
            // 
            LabelMoneda.AutoSize = true;
            LabelMoneda.Location = new Point(37, 302);
            LabelMoneda.Margin = new Padding(4, 0, 4, 0);
            LabelMoneda.Name = "LabelMoneda";
            LabelMoneda.Size = new Size(82, 25);
            LabelMoneda.TabIndex = 11;
            LabelMoneda.Text = "Moneda:";
            // 
            // TxtCuil
            // 
            TxtCuil.Location = new Point(123, 167);
            TxtCuil.Margin = new Padding(4, 5, 4, 5);
            TxtCuil.Name = "TxtCuil";
            TxtCuil.Size = new Size(377, 31);
            TxtCuil.TabIndex = 4;
            // 
            // labelCuil
            // 
            labelCuil.AutoSize = true;
            labelCuil.Location = new Point(70, 180);
            labelCuil.Margin = new Padding(4, 0, 4, 0);
            labelCuil.Name = "labelCuil";
            labelCuil.Size = new Size(45, 25);
            labelCuil.TabIndex = 10;
            labelCuil.Text = "Cuil:";
            // 
            // TxtContra
            // 
            TxtContra.Location = new Point(123, 253);
            TxtContra.Margin = new Padding(4, 5, 4, 5);
            TxtContra.Name = "TxtContra";
            TxtContra.PasswordChar = '*';
            TxtContra.Size = new Size(377, 31);
            TxtContra.TabIndex = 6;
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Location = new Point(14, 262);
            labelContra.Margin = new Padding(4, 0, 4, 0);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(105, 25);
            labelContra.TabIndex = 8;
            labelContra.Text = "Contraseña:";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(123, 210);
            TxtUser.Margin = new Padding(4, 5, 4, 5);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(377, 31);
            TxtUser.TabIndex = 5;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(123, 122);
            TxtCorreo.Margin = new Padding(4, 5, 4, 5);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(377, 31);
            TxtCorreo.TabIndex = 3;
            // 
            // TxtApellido
            // 
            TxtApellido.Location = new Point(123, 78);
            TxtApellido.Margin = new Padding(4, 5, 4, 5);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(377, 31);
            TxtApellido.TabIndex = 2;
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(123, 35);
            TxtNombre.Margin = new Padding(4, 5, 4, 5);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(377, 31);
            TxtNombre.TabIndex = 1;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(43, 223);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(76, 25);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(49, 135);
            labelCorreo.Margin = new Padding(4, 0, 4, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(70, 25);
            labelCorreo.TabIndex = 2;
            labelCorreo.Text = "Correo:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(37, 92);
            labelApellido.Margin = new Padding(4, 0, 4, 0);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(82, 25);
            labelApellido.TabIndex = 1;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(37, 48);
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
            BtnCancelar.Location = new Point(306, 467);
            BtnCancelar.Margin = new Padding(4, 5, 4, 5);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(153, 48);
            BtnCancelar.TabIndex = 8;
            BtnCancelar.Text = "Limpiar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.Cursor = Cursors.Hand;
            BtnAceptar.Location = new Point(87, 467);
            BtnAceptar.Margin = new Padding(4, 5, 4, 5);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(147, 48);
            BtnAceptar.TabIndex = 7;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // labelTenesCuenta
            // 
            labelTenesCuenta.AutoSize = true;
            labelTenesCuenta.Location = new Point(50, 542);
            labelTenesCuenta.Margin = new Padding(4, 0, 4, 0);
            labelTenesCuenta.Name = "labelTenesCuenta";
            labelTenesCuenta.Size = new Size(183, 25);
            labelTenesCuenta.TabIndex = 3;
            labelTenesCuenta.Text = "¿Ya tenes una cuenta?";
            // 
            // botonLogin
            // 
            botonLogin.Cursor = Cursors.Hand;
            botonLogin.Location = new Point(60, 587);
            botonLogin.Margin = new Padding(4, 5, 4, 5);
            botonLogin.Name = "botonLogin";
            botonLogin.Size = new Size(107, 38);
            botonLogin.TabIndex = 9;
            botonLogin.Text = "Login";
            botonLogin.UseVisualStyleBackColor = true;
            botonLogin.Click += botonLogin_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 678);
            Controls.Add(botonLogin);
            Controls.Add(labelTenesCuenta);
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