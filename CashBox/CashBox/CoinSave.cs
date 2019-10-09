using CashBox.Dto;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
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
        public bool FromConfiguration { get; set; } = true;

        private UnitOfWork _unitOfWork;
        private BaseRepository<MCoin> _mCoinRepository;
        public CoinSave()
        {
            InitializeComponent();
            
            _unitOfWork = new UnitOfWork();
            _mCoinRepository = _unitOfWork.Repository<MCoin>();

            FillUpNumerics();
        }

        private void FillUpNumerics()
        {
            var coins = _mCoinRepository.GetAll().ToList();

            nUDOneHundred.Value = coins.Count(e => e.Value == 100);
            nUDTwoHundred.Value = coins.Count(e => e.Value == 200);
            nUDFiveHundred.Value = coins.Count(e => e.Value == 500);
            nUDOneThousand.Value = coins.Count(e => e.Value == 1000);
            nUDTwoThousand.Value = coins.Count(e => e.Value == 2000);
        }

        public CoinSave(FrmDepositDto frmDepositDto) 
        {
            InitializeComponent();
           
            _frmDepositDto = frmDepositDto;
            _unitOfWork = new UnitOfWork();
            _mCoinRepository = _unitOfWork.Repository<MCoin>();

            FromConfiguration = false;
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

            List<int> coins = new List<int>();


            coins.AddRange(Enumerable.Repeat(100, (int)nUDOneHundred.Value));
            coins.AddRange(Enumerable.Repeat(200, (int)nUDTwoHundred.Value));
            coins.AddRange(Enumerable.Repeat(500, (int)nUDFiveHundred.Value));
            coins.AddRange(Enumerable.Repeat(1000, (int)nUDOneThousand.Value));
            coins.AddRange(Enumerable.Repeat(2000, (int)nUDTwoThousand.Value));


            if (FromConfiguration)
            {

                var configuration = new FrmConfiguration(coins);
                configuration.Show();
            }
            else
            {
                _frmDepositDto.Amount = totalValue;
                _frmDepositDto.CoinElements.Clear();
                _frmDepositDto.CoinElements.AddRange(coins);

                var deposit = new FrmDeposit(_frmDepositDto);
                deposit.Show();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
