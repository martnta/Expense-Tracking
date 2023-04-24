using ExpenseTrackingSystem.Model;
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

namespace ExpenseTrackingSystem.Pages
{
    public partial class FrmTransactions : Form
    {
        public ExpenseItemViewModel _itemViewMondel;
        
        public FrmTransactions()
        {
            InitializeComponent();

            _itemViewMondel = new ExpenseItemViewModel();
            cmbMonth.DataSource = _itemViewMondel.Months;
            cmbPayment.DataSource = _itemViewMondel.PaymentTypes;
            cmbCategory.DataSource = _itemViewMondel.Categories;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            ExpenseItem expenseItem = new ExpenseItem();

            expenseItem.ItemName = txtTransaction.Text;
            expenseItem.description = txtAmmount.Text;
            expenseItem.cost = Int32.Parse(txtAmmount.Text);
            expenseItem.category = cmbCategory.Text;
            expenseItem.paymentType = cmbPayment.Text;
            expenseItem.month = cmbMonth.Text;

            _itemViewMondel.AddExpenseItem(expenseItem);
            txtDescription.Clear();
            txtTransaction.Clear();
            txtAmmount.Clear();
            MessageBox.Show("Transaction added successful", "EXPENSE TRANSACTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
