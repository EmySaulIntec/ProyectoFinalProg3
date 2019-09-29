using CashBox;
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
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;

        public FrmDeposit()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoaDepositar.Text) || txtMontoaDepositar.Text.Trim() == "0")
            {
                MessageBox.Show("Monto no valido");
                return;
            }

            if (txtIdentification.Text == "402-1277899-3")
            {
                if (txtNoCuenta.Text == "123456789")
                {
                    if (txtNoCuentaDestino.Text == "987654321")
                    {
                        MessageBox.Show("El Usuario es Rubert, Portador de la cedula [" + txtIdentification.Text + "] y de numero de cuenta [" + txtNoCuenta.Text + "] realizo un deposito de [" + txtMontoaDepositar.Text + " pesos] a la cuenta [" + txtNoCuentaDestino.Text + "]");

                        double amount = Convert.ToDouble(txtMontoaDepositar.Text);

                        Settings.AddToCash(amount);

                        _transactionRepository.Insert(new Transaction()
                        {
                            CasherId = Settings.LoggedUser.Id,
                            OriginAccount = txtNoCuenta.Text,
                            DestinyAccount = txtNoCuentaDestino.Text,
                            Identification = txtIdentification.Text,
                            IdentificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport,
                            Amount = amount,
                            TransactionType = TransactionTypeEnum.Deposit
                        });

                        FrmHome abrir = new FrmHome();
                        abrir.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El numero de cuenta destino es invalido o no existe");
                    }
                    
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
