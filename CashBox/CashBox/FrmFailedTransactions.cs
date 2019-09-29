using CashBox.Services;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using ProyectoFinalProg3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashBox
{
    public partial class FrmFailedTransactions : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactonRepository;
        private readonly ICashService _cashService;

        public FrmFailedTransactions()
        {
            InitializeComponent();

            unitOfWork = new UnitOfWork();
            _transactonRepository = unitOfWork.Repository<Transaction>();

            _cashService = new CashService();
        }

        public Transaction SelectedTransaction { get; private set; }

        private void FrmFailedTransactions_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            listUsers.Items.Clear();
            var transacctiones = _transactonRepository.GetAll().Where(e=>e.Status == TransactionStatusEnum.Incompleted).ToArray();
            listUsers.Items.AddRange(transacctiones);

            lblNoIdentification.Text = string.Empty;
            lblCasher.Text = string.Empty;
            lblTransactionType.Text = string.Empty;
            lblOriginAccount.Text = string.Empty;
            lblDestinyAccount.Text = string.Empty;
            lblDate.Text = string.Empty;

            radioIdentification.Checked = true;
            radioPassport.Checked = false;
        }

        private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndex != -1)
            {
                SelectedTransaction = listUsers.SelectedItem as Transaction;

                lblNoIdentification.Text = SelectedTransaction.Identification;
                lblCasher.Text = SelectedTransaction.Casher.UserName;
                lblTransactionType.Text = SelectedTransaction.TransactionType == TransactionTypeEnum.Deposit ? "Deposito" : "Retiro";
                lblOriginAccount.Text = SelectedTransaction.OriginAccount;
                lblDestinyAccount.Text = SelectedTransaction.DestinyAccount;
                lblDate.Text = $"{SelectedTransaction.CreationTime.ToLongDateString()} : {SelectedTransaction.CreationTime.ToShortTimeString()}";

                radioIdentification.Checked = SelectedTransaction.IdentificationType == IdentificationTypeEnum.Cedula;
                radioPassport.Checked = SelectedTransaction.IdentificationType == IdentificationTypeEnum.Passport;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (SelectedTransaction != null)
            {
                if (SelectedTransaction.TransactionType == TransactionTypeEnum.Deposit)
                    _cashService.Deposit(SelectedTransaction);
                else
                    _cashService.Retirement(SelectedTransaction);

                Init();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Close();
        }
    }
}
