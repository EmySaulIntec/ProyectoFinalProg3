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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            if (txtCedulaoPasaporte.Text == "402-1277899-3")
            {
                if (txtNoCuenta.Text == "123456789")
                {
                    MessageBox.Show("El Usuario es Rubert, Portador de la cedula [" + txtCedulaoPasaporte.Text + "] y de numero de cuenta [" + txtNoCuenta.Text + "] realizo un retiro de [" + txtMontoaRetirar.Text + " pesos] de la cuenta [" + txtNoCuenta.Text + "]");
                    Inicio abrir = new Inicio();
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
            Inicio abrir = new Inicio();
            abrir.Show();
            this.Hide();
        }
    }
}
