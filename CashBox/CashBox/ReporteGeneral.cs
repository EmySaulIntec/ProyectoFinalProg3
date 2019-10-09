
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
using CashBox.CashDBDataSetTableAdapters;

namespace CashBox
{
    public partial class ReporteGeneral : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<Transaction> _transactionRepository;
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ReporteGeneral()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _transactionRepository = unitOfWork.Repository<Transaction>();

            
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            //var transactionsD = _transactionRepository.GetAll().Where(t => t.TransactionType == TransactionTypeEnum.Deposit).ToList();
            //var transactionsR = _transactionRepository.GetAll().Where(t => t.TransactionType == TransactionTypeEnum.Retirement).ToList(); 

            reportViewer1.LocalReport.ReportPath = @"C:\Cash\ProyectoFinalProg3\CashBox\CashBox\GeneralReport.rdlc";
            TransactionsTableAdapter adapter = new TransactionsTableAdapter();
            int TransactionType = int.Parse(txtTipoTransaccion.Text);
            ReportDataSource reportDataSource = new ReportDataSource("DataSetTransactionType", (DataTable)adapter.GetDataByTransactionType(TransactionType));
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();



        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
