using StudentSystem.WindowsFormsCliente;

namespace DesktopBankUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void registerLabel_Click(object sender, EventArgs e)
        {
            FormRegister frmRegister = new();
            frmRegister.Show();
            this.Hide();
        }

        private void opcionSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
