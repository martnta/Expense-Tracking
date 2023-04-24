using ExpenseTrackingSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseTrackingSystem.ViewModel;

namespace ExpenseTrackingSystem.Pages
{
    public partial class FrmExpensePage : Form
    {
        private readonly ExpenseItemViewModel expenseItemViewModel;
        public FrmExpensePage()
        {
            InitializeComponent();

            expenseItemViewModel = new ExpenseItemViewModel();

            tblExpenses.DataSource = expenseItemViewModel.ExpenseItems;

            tblExpenses.Columns.Add("Id", "ID");
            tblExpenses.Columns.Add("Cost", "Cost");
            tblExpenses.Columns.Add("Description", "Description");
            tblExpenses.Columns.Add("Category", "Category");
            tblExpenses.Columns.Add("PaymentType", "Payment Type");
            tblExpenses.Columns.Add("Month", "Month");

            tblExpenses.Columns["Id"].DataPropertyName = "Id";
            tblExpenses.Columns["Cost"].DataPropertyName = "cost";
            tblExpenses.Columns["Description"].DataPropertyName = "description";
            tblExpenses.Columns["Category"].DataPropertyName = "category";
            tblExpenses.Columns["PaymentType"].DataPropertyName = "paymentType";
            tblExpenses.Columns["Month"].DataPropertyName = "month";

            expenseItemViewModel.getExpenseItems();
        }

        private void CmdExpenseDialog_Click(object sender, EventArgs e)
        {
            new FrmTransactions().ShowDialog();
        }

        private void tblExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this page is unde construction");
        }
    }
}
