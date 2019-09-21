using DatabaseProject.Models;
using DatabaseProject.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CashBox
{
    public partial class FrmUser : Form
    {
        private UnitOfWork unitOfWork;
        private BaseRepository<User> _userRepository;

        public User SelectedUser { get; set; }
        public FrmUser()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            _userRepository = unitOfWork.Repository<User>();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }


        private void button1_Click(object sender, EventArgs e)
        {


        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Nombre de usuario invalido");
                return;
            }

            if (_userRepository.GetAll().Any(u => u.UserName == txtUserName.Text))
            {
                MessageBox.Show("Este usuario existe");
                return;
            }

            _userRepository.Insert(new User()
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                IsCasher = chkIsCasher.Checked
            });

            SelectedUser = null;
            lblUser.Text = string.Empty;
            Init();
            MessageBox.Show("Usuario creado");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Nombre de usuario invalido");
                return;
            }

            if (SelectedUser != null)
            {
                if (_userRepository.GetAll().Any(u => u.Id != SelectedUser.Id && u.UserName == txtUserName.Text))
                {
                    MessageBox.Show("Este usuario existe");
                    return;
                }

                SelectedUser.UserName = txtUserName.Text;
                SelectedUser.Password = txtPassword.Text;
                SelectedUser.Email = txtEmail.Text;
                SelectedUser.IsCasher = chkIsCasher.Checked;

                _userRepository.Update(SelectedUser);
                Init();

                MessageBox.Show("Usuario modificado");
            }
            else
            {
                MessageBox.Show("Seleccione un usuario.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listUsers.SelectedIndex != -1)
            {
                SelectedUser = listUsers.SelectedItem as User;

                txtUserName.Text = this.SelectedUser.UserName;
                txtPassword.Text = this.SelectedUser.Password;
                txtEmail.Text = this.SelectedUser.Email;
                chkIsCasher.Checked = this.SelectedUser.IsCasher;

                lblUser.Text = SelectedUser.UserName;
                lblStatus.Text = SelectedUser.IsEnabled ? "Si" : "No";
                lblShowActive.Visible = true;

                if (SelectedUser.IsEnabled)
                {
                    btnActive.Enabled = false;

                    btnDesactive.Enabled = true;
                }
                else
                {
                    btnActive.Enabled = true;
                    btnDesactive.Enabled = false;
                }
            }
            else
                lblUser.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeStateToUser(true);
        }

        private void ChangeStateToUser(bool state)
        {
            if (SelectedUser != null)
            {
               
                SelectedUser.IsEnabled = state;
                _userRepository.Update(SelectedUser);
                Init();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeStateToUser(false);

        }

      
        private void Init()
        {
            listUsers.Items.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();

            chkIsCasher.Checked = false;
            lblStatus.Text = string.Empty;
            lblUser.Text = string.Empty;

            lblShowActive.Visible = false;

            btnActive.Enabled = false;
            btnDesactive.Enabled = false;

            var users = _userRepository.GetAll().ToArray();
            listUsers.Items.AddRange(users);
        }
    }
}
