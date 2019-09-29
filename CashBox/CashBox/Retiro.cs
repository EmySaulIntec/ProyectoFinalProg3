using CashBox;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using System;
using System.Windows.Forms;

namespace ProyectoFinalProg3
{
    public partial class FrmmRetirement : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;
        public FrmmRetirement()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoaRetirar.Text) || txtMontoaRetirar.Text.Trim() == "0")
            {
                MessageBox.Show("Monto no valido");
                return;
            }

            if (txtIdentification.Text == "402-1277899-3")
            {
                if (txtNoCuenta.Text == "123456789")
                {
                    double amount = Convert.ToDouble(txtMontoaRetirar.Text);

                    if (!Settings.SubstractToCash(amount))
                    {
                        MessageBox.Show("No se puede hacer la transacción caja vacía.");
                        return;
                    }

                    _transactionRepository.Insert(new Transaction()
                    {
                        CasherId = Settings.LoggedUser.Id,
                        OriginAccount = txtNoCuenta.Text,
                        Identification = txtIdentification.Text,
                        IdentificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport,
                        Amount = amount,
                        TransactionType = TransactionTypeEnum.Retirement
                    });


                    MessageBox.Show("El Usuario es Rubert, Portador de la cedula [" + txtIdentification.Text + "] y de numero de cuenta [" + txtNoCuenta.Text + "] realizo un retiro de [" + txtMontoaRetirar.Text + " pesos] de la cuenta [" + txtNoCuenta.Text + "]");
                    FrmHome abrir = new FrmHome();
                    abrir.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("El numero de cuenta es incorrecto");
                }
            }
            else
            {
                MessageBox.Show("El numero de cedula es incorrecto");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmHome abrir = new FrmHome();
            abrir.Show();
            this.Hide();
        }

        private void txtMontoaRetirar_KeyPress(object sender, KeyPressEventArgs e)
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
