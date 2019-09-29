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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BtnValidarCliente_Click(object sender, EventArgs e)
        {
            ValidarCliente abrir = new ValidarCliente();
            abrir.Show();
            this.Hide();
        }

        private void BtnDeposito_Click(object sender, EventArgs e)
        {
            Deposito abrir = new Deposito();
            abrir.Show();
            this.Hide();
        }

        private void BtnRetiro_Click(object sender, EventArgs e)
        {
            Retiro abrir = new Retiro();
            abrir.Show();
            this.Hide();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {

            Login abrir = new Login();
            abrir.Show();
            this.Hide();
        }

       
    }
}
