using DatabaseProject.Models;
using DatabaseProject.Repositories;
using ProyectoFinalProg3;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CashBox
{
    public partial class FrmConfiguration : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<DailyClose> _dailyCloseRepository;

        public FrmConfiguration()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _dailyCloseRepository = unitOfWork.Repository<DailyClose>();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {

            var initTime = TimeSpan.FromHours(cmbInitHour.SelectedIndex).Add(TimeSpan.FromMinutes(cmbInitMinut.SelectedIndex));
            var endTime = TimeSpan.FromHours(cmbEndHour.SelectedIndex).Add(TimeSpan.FromMinutes(cmbEndMinut.SelectedIndex));

            if (initTime >= endTime)
            {
                MessageBox.Show("El tiempo inicial no puede ser menor que el final");
                return;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Guardado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHome inicio = new FrmHome();
            inicio.Show();
            this.Close();
        }

        private void FrmConfiguration_Load(object sender, EventArgs e)
        {
            SetCashTime();
            SetCashBox();
        }

        private void SetCashBox()
        {
            var currentDate = DateTime.Now.Date;

            if (_dailyCloseRepository.GetAll().Any(d => d.CreationTime >= currentDate && d.FinalAmount.HasValue))
            {
                btnCloseCash.Enabled = false;
                txtCash.Enabled = false;
            }

            CashBox cashBox = Settings.GetCashBox();
            txtCash.Text = cashBox.Amount.ToString();

            if (cashBox.CashIsOpen)
                btnCloseCash.Text = "Cerrar caja";
            else
                btnCloseCash.Text = "Abrir caja";
        }

        private void SetCashTime()
        {
            CloseTime closeTime = Settings.GetCloseTime();
            cmbInitHour.SelectedIndex = closeTime.InitHour;
            cmbInitMinut.SelectedIndex = closeTime.InitMinute;
            cmbEndHour.SelectedIndex = closeTime.EndHour;
            cmbEndMinut.SelectedIndex = closeTime.EndMinute;
        }

        private void cmbInitHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInitHour.SelectedIndex != -1 && Properties.Settings.Default.InitHour != cmbInitHour.SelectedIndex)
            {
                Properties.Settings.Default.InitHour = cmbInitHour.SelectedIndex;
            }
        }

        private void cmbInitMinut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInitMinut.SelectedIndex != -1 && Properties.Settings.Default.InitMinute != cmbInitMinut.SelectedIndex)
            {
                Properties.Settings.Default.InitMinute = cmbInitMinut.SelectedIndex;
            }
        }

        private void cmbEndHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEndHour.SelectedIndex != -1 && Properties.Settings.Default.EndHour != cmbEndHour.SelectedIndex)
            {
                Properties.Settings.Default.EndHour = cmbEndHour.SelectedIndex;
            }
        }

        private void cmbEndMinut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEndMinut.SelectedIndex != -1 && Properties.Settings.Default.EndMinute != cmbEndMinut.SelectedIndex)
            {
                Properties.Settings.Default.EndMinute = cmbEndMinut.SelectedIndex;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }


        }

        private void btnCloseCash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCash.Text))
                txtCash.Text = "0";

            if (MessageBox.Show($"Desea {btnCloseCash.Text} con {txtCash.Text}", btnCloseCash.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            Properties.Settings.Default.Amount = Convert.ToDecimal(txtCash.Text);

            var currentDate = DateTime.Now.Date;

            DailyClose currentDailyClose = _dailyCloseRepository.GetAll().FirstOrDefault(d => d.CreationTime >= currentDate);


            if (currentDailyClose == null)
            {
                _dailyCloseRepository.Insert(new DailyClose()
                {
                    CasherId = Settings.LoggedUser.Id,
                    InitialAmount = Properties.Settings.Default.Amount
                });

                Properties.Settings.Default.CashIsOpen = true;
            }
            else if (!currentDailyClose.FinalAmount.HasValue)
            {
                currentDailyClose.FinalAmount = Properties.Settings.Default.Amount;

                _dailyCloseRepository.Update(currentDailyClose);

                Properties.Settings.Default.CashIsOpen = false;
            }
            else
            {
                MessageBox.Show("Caja ya fue cerrada.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Properties.Settings.Default.Save();

            SetCashBox();
        }
    }
}
