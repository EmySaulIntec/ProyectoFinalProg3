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
    public partial class FrmValidateClient : Form
    {
        public FrmValidateClient()
        {
            InitializeComponent();
        }

        private void LblBankintoch_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (txtCedulaoPasaporte.Text == "402-1277899-3")
            {
                if (txtNoCuenta.Text == "123456789")
                {
                    MessageBox.Show("El Usuario es Rubert, Portador de la cedula " + txtCedulaoPasaporte.Text + " y de numero de cuenta " + txtNoCuenta.Text + " es valido!");
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
    }
}
