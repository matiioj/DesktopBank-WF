using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.Services;

namespace DesktopBankUI
{
    public partial class FormConfirmTransferencia : Form
    {
       
        Account _currentAccount;
        private readonly CreateTransferService _createTransferService;
        public FormConfirmTransferencia(Account currentAccount, CreateTransferService createTransferService)
        {
            _createTransferService = createTransferService;
            _currentAccount = currentAccount;
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void FormDeposit_Load(object sender, EventArgs e)
        {

        }

        private async void BtnDepo_Click(object sender, EventArgs e)
        {
            //si tryparse da true amount almacena el valor sino almacena 0
            if (decimal.TryParse(Text, out decimal amount))
            {
                if (amount > 0)
                {
                    _createTransferService.ExecuteTransfer(currentAccount, amount, datoDeCuenta);
                }
                else
                {
                    MessageBox.Show("valor invalido", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("cantidad no valida", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
