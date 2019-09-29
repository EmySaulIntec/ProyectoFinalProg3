using CashBox;
using CashBox.Services;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalProg3
{
    public partial class FrmDeposit : Form
    {
        private readonly ICashService _cashService;
        public FrmDeposit()
        {
            InitializeComponent();

            _cashService = new CashService();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoaDepositar.Text) || txtMontoaDepositar.Text.Trim() == "0")
            {
                MessageBox.Show("Monto no valido");
                return;
            }

            double amount = Convert.ToDouble(txtMontoaDepositar.Text);

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

            _cashService.Deposit(transaction);

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
    }
}
