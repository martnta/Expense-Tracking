using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackingSystem.Pages;

namespace ExpenseTrackingSystem.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.Opacity = 1;

            dashboardPageBtn.BackColor = Color.Black;
            expensesPageBtn.BackColor = Color.Transparent;

            pnlDashboard.Visible = true;
            pnlExpense.Visible = false;

            this.PagePanel.Controls.Clear();

            FrmDashboardPage dashboard = new FrmDashboardPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;

            this.PagePanel.Controls.Add(dashboard);

            dashboard.Show();
        }

        private void DashboardPageBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

            dashboardPageBtn.BackColor = Color.Black;
            expensesPageBtn.BackColor = Color.Transparent;

            pnlDashboard.Visible = true;
            pnlExpense.Visible = false;

            this.PagePanel.Controls.Clear();

            FrmDashboardPage dashboard = new FrmDashboardPage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;

            this.PagePanel.Controls.Add(dashboard);

            dashboard.Show();
        }

        private void ExpensesPageBtn_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;

            dashboardPageBtn.BackColor = Color.Transparent;
            expensesPageBtn.BackColor = Color.Black;

            pnlDashboard.Visible = false;
            pnlExpense.Visible = true;

            this.PagePanel.Controls.Clear();

            FrmExpensePage expense = new FrmExpensePage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            expense.FormBorderStyle = FormBorderStyle.None;

            this.PagePanel.Controls.Add(expense);

            expense.Show();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void PageLogoutBtn_Click(object sender, EventArgs e)
        {
            pageLogoutBtn.BackColor = Color.FromArgb(46, 51, 73);

            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
