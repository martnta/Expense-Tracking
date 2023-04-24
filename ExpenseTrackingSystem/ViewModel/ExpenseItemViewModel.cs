using ExpenseTrackingSystem.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackingSystem.ViewModel
{
   public class ExpenseItemViewModel
    {
        public string _connectionString = "server=localhost;user id=root;password=;database=expense_tracking";

        public BindingList<ExpenseItem> ExpenseItems { get; set; }
        public List<PaymentType> PaymentTypes { get; set; }
        public List<Month> Months { get; set; }
        public List<Category> Categories { get; set; }


        public ExpenseItemViewModel()
        {
            ExpenseItems = new BindingList<ExpenseItem>();
            PaymentTypes = Enum.GetValues(typeof(PaymentType)).Cast<PaymentType>().ToList();
            Months = Enum.GetValues(typeof(Month)).Cast<Month>().ToList();
            Categories = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            getExpenseItems();
        }

        public void getExpenseItems()
        {
            ExpenseItems.Clear(); 
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "Select * From expensei_item";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExpenseItem expenseItem = new ExpenseItem();
                            expenseItem.Id = (int)reader["id"];
                            expenseItem.ItemName = (string)reader["itemName"];
                            expenseItem.cost = (float)reader["cost"];
                            expenseItem.description = (string)reader["description"];
                            expenseItem.category = (string)reader["category"];
                            expenseItem.paymentType = (string)reader["payment_type"];
                            expenseItem.month = (string)reader["month"];
                            ExpenseItems.Add(expenseItem);
                        }
                    }
                }
            }
        }

        public void AddExpenseItem(ExpenseItem expenseItem)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO expensei_item (itemName,cost, description,category, payment_type, month) VALUES (@ItemName,@Cost,@Category, @Description, @PaymentType, @Month)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", expenseItem.ItemName);
                    command.Parameters.AddWithValue("@Cost", expenseItem.cost);
                    command.Parameters.AddWithValue("@Description", expenseItem.description);
                    command.Parameters.AddWithValue("@PaymentType", expenseItem.paymentType);
                    command.Parameters.AddWithValue("@Category", expenseItem.category);
                    command.Parameters.AddWithValue("@Month", expenseItem.month);
                    command.ExecuteNonQuery();
                }
            }

            ExpenseItems.Add(expenseItem);
        }


        public void UpdateExpenseItem(ExpenseItem expenseItem)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE expensei_item SET itemName = @ItemName, cost = @Cost, description = @Description,category = @Category, payment_type = @PaymentType, month = @Month WHERE id = @Id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", expenseItem.ItemName);
                    command.Parameters.AddWithValue("@Cost", expenseItem.cost);
                    command.Parameters.AddWithValue("@Description", expenseItem.description);
                    command.Parameters.AddWithValue("@Category", expenseItem.category);
                    command.Parameters.AddWithValue("@PaymentType", expenseItem.paymentType);
                    command.Parameters.AddWithValue("@Month", expenseItem.month);
                    command.Parameters.AddWithValue("@Id", expenseItem.Id);
                    command.ExecuteNonQuery();
                }
            }

            // Update the expense item in the binding list
            int index = ExpenseItems.IndexOf(expenseItem);
            ExpenseItems[index] = expenseItem;
        }

        public void deleteExpense(ExpenseItem expenseItem)
        {
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM expensei_item WHERE id = @Id";
                using(MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", expenseItem.Id);
                    command.ExecuteNonQuery();
                }
            }
            ExpenseItems.Remove(expenseItem);
        }
    }
}
