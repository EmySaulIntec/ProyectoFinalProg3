using CashBox;
using CashBox.Dto;
using CashBox.Services;
using DatabaseProject.Models;
using System;
using System.Windows.Forms;

namespace ProyectoFinalProg3
{
    public partial class FrmDeposit : Form
    {
        private readonly ICashService _cashService;
        private FrmDepositDto frmDepositDto;

        public FrmDeposit()
        {
            InitializeComponent();

            _cashService = new CashService();
        }

        public FrmDeposit(FrmDepositDto frmDepositDto) : this()
        {
            
            this.frmDepositDto = frmDepositDto;
            txtIdentification.Text = frmDepositDto.Identification;
            txtNoCuenta.Text = frmDepositDto.OriginAccount;
            txtNoCuentaDestino.Text = frmDepositDto.DestinyAccount;

            radioIdentification.Checked = frmDepositDto.IdentificationType == IdentificationTypeEnum.Cedula;
            radioPassport.Checked = frmDepositDto.IdentificationType == IdentificationTypeEnum.Passport;
            txtMontoaDepositar.Text = frmDepositDto.Amount.ToString();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoaDepositar.Text) || txtMontoaDepositar.Text.Trim() == "0")
            {
                MessageBox.Show("Monto no valido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = Convert.ToDecimal(txtMontoaDepositar.Text);

            var identificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport;

            var transaction = new Transaction()
            {
                CasherId = Settings.LoggedUser.Id,
                OriginAccount = txtNoCuenta.Text,
                DestinyAccount = txtNoCuentaDestino.Text,
                Identification = txtIdentification.Text,
                IdentificationType = identificationType,
                Amount = amount,
                TransactionType = TransactionTypeEnum.Deposit
            };

            _cashService.Deposit(transaction, frmDepositDto);

            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmHome abrir = new FrmHome();
            abrir.Show();
            this.Hide();
        }

        private void txtMontoaDepositar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoinSave coinSave = new CoinSave(new FrmDepositDto()
            {
                DestinyAccount = txtNoCuentaDestino.Text,
                OriginAccount = txtNoCuenta.Text,
                Identification = txtIdentification.Text,
                IdentificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport
            });

            coinSave.Show();
            this.Close();
        }
    }
}
