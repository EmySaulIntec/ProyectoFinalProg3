
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatabaseProject.Repositories;
using DatabaseProject.Models;

namespace CashBox
{
    public partial class Reporte : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CashDB;Integrated Security=True");
        public Reporte()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();

            
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            var transactionsD = _transactionRepository.GetAll().Where(t => t.TransactionType == TransactionTypeEnum.Deposit).ToList();
            var transactionsR = _transactionRepository.GetAll().Where(t => t.TransactionType == TransactionTypeEnum.Retirement).ToList(); 
            //SqlCommand comando = new SqlCommand("Select * from Transactions", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = comando;
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            //gTransactions.DataSource = table;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cashDBDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.cashDBDataSet.Transactions);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
