using CashBox;
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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (!Settings.LoggedUser.IsAdmin)
            {
                configuracionToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
                transaccionesFallidasToolStripMenuItem.Visible = false;
            }
        }

        private void BtnValidarCliente_Click(object sender, EventArgs e)
        {
            if (!Settings.CanDoTransactions())
            {
                MessageBox.Show("No se permiten transacciones caja cerrada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmValidateClient abrir = new FrmValidateClient();
            abrir.Show();
            this.Hide();
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            
            if (!Settings.LoggedUser.IsCasher)
            {
                MessageBox.Show("Este usuario no es un cajero, no puede realizar esta transacción.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Settings.CanDoTransactions())
            {
                MessageBox.Show("No se permiten transacciones caja cerrada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            FrmDeposit abrir = new FrmDeposit();
            abrir.Show();
            this.Hide();
        }

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            if (!Settings.LoggedUser.IsCasher)
            {
                MessageBox.Show("Este usuario no es un cajero, no puede realizar esta transacción.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!Settings.CanDoTransactions())
            {
                MessageBox.Show("No se permiten transacciones caja cerrada", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FrmmRetirement abrir = new FrmmRetirement();
            abrir.Show();
            this.Hide();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {

            FrmLogin abrir = new FrmLogin();
            abrir.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmConfiguration configuration = new FrmConfiguration();
            configuration.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser frmUser = new FrmUser();
            frmUser.Show();
            this.Hide();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConfiguration = new FrmConfiguration();
            frmConfiguration.Show();
            this.Hide();
        }

        private void transaccionesFallidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmFailedTransaction = new FrmFailedTransactions();
            frmFailedTransaction.Show();
            this.Hide();
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            ReporteGeneral abrir = new ReporteGeneral();
            abrir.Show();
            this.Hide();
        }
    }
}
