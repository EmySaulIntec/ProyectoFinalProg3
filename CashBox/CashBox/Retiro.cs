using CashBox;
using CashBox.Services;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalProg3
{
    public partial class FrmmRetirement : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;

        private readonly ICashService _cashService;

        private BaseRepository<MCoin> _mcoinRepository;

        public FrmmRetirement()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();
            _mcoinRepository = unitOfWork.Repository<MCoin>();

            _cashService = new CashService();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoaRetirar.Text) || txtMontoaRetirar.Text.Trim() == "0")
            {
                MessageBox.Show("Monto no valido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount = Convert.ToDecimal(txtMontoaRetirar.Text);

            var transaction = new Transaction()
            {
                CasherId = Settings.LoggedUser.Id,
                OriginAccount = txtNoCuenta.Text,
                Identification = txtIdentification.Text,
                IdentificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport,
                Amount = amount,
                TransactionType = TransactionTypeEnum.Retirement
            };

            List<MCoin> coinsAdded = new List<MCoin>();

            if (RemoveCoins(amount, ref coinsAdded))
            {
                _cashService.Retirement(transaction, coinsAdded);

                var coins = string.Join(",", coinsAdded.Select(d=>d.Value));

                MessageBox.Show($"Monedas devueltas:\n{coins}");
            }
            

            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private bool RemoveCoins(decimal value, ref List<MCoin> coinsAdded)
        {
            var coins = _mcoinRepository.GetAll().OrderByDescending(e => e.Value).ToList();

            while (value > 0 && coins.Any())
            {
                if (value >= coins[0].Value)
                {
                    value -= coins[0].Value;
                    coinsAdded.Add(coins[0]);
                }

                coins.RemoveAt(0);
            }

            return value == 0;
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
