using CashBox;
using DatabaseProject.Models;
using DatabaseProject.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinalProg3
{
    public partial class FrmLogin : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<User> _userRepository;
        public FrmLogin()
        {
            InitializeComponent();

            unitOfWork = new UnitOfWork();
            _userRepository = unitOfWork.Repository<User>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var loggedUser = _userRepository.GetAll().FirstOrDefault(u => u.UserName == txtUsername.Text
            && u.Password == txtPassword.Text && u.IsEnabled);

            if (loggedUser == null)
            {
                MessageBox.Show(@"Usuario y/o contraseña invalidos.");
                return;
            }

            Settings.LoggedUser = loggedUser;

            FrmHome abrir = new FrmHome();
            abrir.Show();
            this.Hide();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
