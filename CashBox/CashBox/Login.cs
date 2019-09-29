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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "rubert")
            {
                if (txtPassword.Text == "0522")
                {
                    Inicio abrir = new Inicio();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
