namespace DesktopBankUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
        }

<<<<<<< Updated upstream
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //Buscar en la Lista de Usuarios si el usuario es valido

            if (UsuarioValido(TxtUser.Text, TxtPassword.Text) == true)
=======
        /*private void opcionSalir_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide(); // oculta FormLogin
        }
        */
        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuarioLogin = TxtUser.Text;
            var contraLogin = TxtPassword.Text;


            //Buscar en la Lista de Usuarios si el usuario es valido
            if (usuarioLogin == "asd" && contraLogin == "asd")
>>>>>>> Stashed changes
            {
                //Puedo ingresar al sistema
            }
            else
            {
                MessageBox.Show("Usuario incorrecto, por favor revise los datos");
            }
<<<<<<< Updated upstream
        }

        private bool UsuarioValido(string username, string clave)
        {
            bool Valido = false;



            return Valido;
=======

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide(); // oculta FormLogin
>>>>>>> Stashed changes
        }
    }
}
