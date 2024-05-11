using StudentSystem.WindowsFormsCliente;

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

        private void opcionSalir_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
            this.Hide(); // oculta FormLogin
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuarioLogin = TxtUser.Text;
            var contraLogin = TxtPassword.Text;
            
            
            //Buscar en la Lista de Usuarios si el usuario es valido
            if (usuarioLogin=="asd"&&contraLogin=="asd")
            {
                FormMain formMain = new FormMain();
                formMain.Show();
                this.Hide(); // oculta FormLogin
            }
            else
            {
                MessageBox.Show("Usuario incorrecto, por favor revise los datos");
            }
            
        }
    }
}
