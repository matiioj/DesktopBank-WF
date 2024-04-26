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

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            //Buscar en la Lista de Usuarios si el usuario es valido

            if (UsuarioValido(TxtUser.Text, TxtPassword.Text) == true)
            {
                //Puedo ingresar al sistema
            }
            else
            {
                MessageBox.Show("Usuario incorrecto, por favor revise los datos");
            }
        }

        private bool UsuarioValido(string username, string clave)
        {
            bool Valido = false;



            return Valido;
        }
    }
}
