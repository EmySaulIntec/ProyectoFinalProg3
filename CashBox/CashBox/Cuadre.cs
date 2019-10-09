using CashBox.CashDBDataSetTableAdapters;
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

namespace CashBox
{
    public partial class Cuadre : Form
    {
        int MontoCaja, TotalDeposito, TotalRetiro, Total;
        public Cuadre()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void TxtTotalCaja_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtMontoCaja_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnGenerarCuadre_Click(object sender, EventArgs e)
        {
            MontoCaja = Convert.ToInt32(txtMontoCaja.Text);
            TotalDeposito = Convert.ToInt32(txtTotalDeposito.Text);
            TotalRetiro = Convert.ToInt32(txtTotalRetiro.Text);
            Total = TotalDeposito - TotalRetiro;
            txtTotalCaja.Text = Total.ToString();

            if (txtTotalCaja.Text == MontoCaja.ToString())
            {
                MessageBox.Show("El Cuadre es Correcto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Hubo un descuadre, favor revisar nuevamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            

        }

        private void Cuadre_Load(object sender, EventArgs e)
        {

            reportViewer1.LocalReport.ReportPath = @"C:\Cash\ProyectoFinalProg3\CashBox\CashBox\ReporteCuadre.rdlc";
            Transactions1TableAdapter adapter = new Transactions1TableAdapter();
            ReportDataSource reportDataSource = new ReportDataSource("DataSetTransactionType", (DataTable)adapter.GetDataBy());
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();
        }
    }
}
