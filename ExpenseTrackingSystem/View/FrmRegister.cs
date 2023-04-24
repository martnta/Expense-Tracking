using System;
using System.Windows.Forms;
using ExpenseTrackingSystem.Forms;
using ExpenseTrackingSystem.Model;
using ExpenseTrackingSystem.ViewModel;

namespace ExpenseTrackingSystem
{
    public partial class FrmRegister : Form
    {
        private readonly UserViewModel _userViewModel;
        public FrmRegister()
        {
            InitializeComponent();
            _userViewModel = new UserViewModel();

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtAddress.Text;
            string password = txtPassword.Text;

            try{
                // Create a new user and add it to the database
                User newUser = new User
                {
                    username = username,
                    email = email,
                    password = password
                };


                _userViewModel.createAcc(username, email, _userViewModel.HashPassword(password));
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
            catch 
            {
                MessageBox.Show("Somethin went wrong");
            }
         
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void CbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }

            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdMinimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
