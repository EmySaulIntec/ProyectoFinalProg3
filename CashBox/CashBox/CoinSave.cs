using CashBox.Dto;
using ProyectoFinalProg3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CashBox
{
    public partial class CoinSave : Form
    {
        private static decimal totalValue = 0;
        private static FrmDepositDto _frmDepositDto;
        public CoinSave(FrmDepositDto frmDepositDto)
        {
            InitializeComponent();

            _frmDepositDto = frmDepositDto;
        }

        private void ChangeAmount()
        {
            totalValue =
              ((nUDOneHundred.Value * 100) + (nUDTwoHundred.Value * 200) + (nUDFiveHundred.Value * 500) + (nUDOneThousand.Value * 1000) + (nUDTwoThousand.Value * 2000));

            lblAmount.Text = totalValue.ToString();
        }

        private void nUDOneHundred_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        private void nUDTwoHundred_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        private void nUDFiveHundred_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        private void nUDOneThousand_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        private void nUDTwoThousand_ValueChanged(object sender, EventArgs e)
        {
            ChangeAmount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmDepositDto.Amount = totalValue;

            _frmDepositDto.CoinElements.Clear();

            _frmDepositDto.CoinElements.AddRange(Enumerable.Repeat(100, (int)nUDOneHundred.Value));
            _frmDepositDto.CoinElements.AddRange(Enumerable.Repeat(200, (int)nUDTwoHundred.Value));
            _frmDepositDto.CoinElements.AddRange(Enumerable.Repeat(500, (int)nUDFiveHundred.Value));
            _frmDepositDto.CoinElements.AddRange(Enumerable.Repeat(1000, (int)nUDOneThousand.Value));
            _frmDepositDto.CoinElements.AddRange(Enumerable.Repeat(2000, (int)nUDTwoThousand.Value));

            FrmDeposit deposit = new FrmDeposit(_frmDepositDto);
            deposit.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
