using DesktopBank.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopBankUI
{
    public partial class FormChangePass : Form
    {
        ValidationService _validationService;
        public FormChangePass()
        {
            _validationService = new();
            InitializeComponent();
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarChP_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void txtMailChangePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviarCode_Click(object sender, EventArgs e)
        {
            string validarMail = txtMailChangePass.Text;

            var mensajeError = _validationService.ValidateOnRegisterFields(validarMail);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show($"¿Enviar código de reestablecimiento de contraseña al correo: {validarMail}?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
    }
}
