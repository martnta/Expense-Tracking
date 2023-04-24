using System;
using System.Linq;
using System.Windows.Forms;
using ExpenseTrackingSystem.Forms;
using ExpenseTrackingSystem.Model;
using ExpenseTrackingSystem.ViewModel;

namespace ExpenseTrackingSystem
{
    public partial class FrmLogin : Form
    {
        private readonly UserViewModel _userViewModel;
        public FrmLogin()
        {
            InitializeComponent();
            _userViewModel = new UserViewModel();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            //attempt = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frm = new FrmRegister();
            frm.Show();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            //Look for the user in database

            User user = _userViewModel.LoginUser(username, password);

            if (user != null)
            {
                this.Hide();
                FrmMain frm = new FrmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username Or Password");
            }
        
        }

        private void CmdMinimise_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
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

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

   


    }
}
