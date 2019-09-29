using CashBox.Services;
using DatabaseProject.Models;
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
        private readonly IIntegrationLayer _integrationLayer;
        public FrmValidateClient()
        {
            InitializeComponent();
            _integrationLayer = new IntegrationLayer();
        }

        private void LblBankintoch_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {

            var identificationType = radioIdentification.Checked ? IdentificationTypeEnum.Cedula : IdentificationTypeEnum.Passport;

            if (_integrationLayer.Validate(txtIdentification.Text, identificationType))
            {
                if (_integrationLayer.Validate(txtNoCuenta.Text))
                {
                    string clientFullName = _integrationLayer.GetClient(txtNoCuenta.Text);

                    MessageBox.Show($"Cliente {clientFullName}, Portador de la cedula { txtIdentification.Text } y de numero de cuenta { txtNoCuenta.Text } es valido!");
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
