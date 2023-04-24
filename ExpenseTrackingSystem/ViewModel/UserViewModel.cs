using ExpenseTrackingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ExpenseTrackingSystem.ViewModel
{
    public class UserViewModel
    {
        public string _connectionString = "server=localhost;user id=root;password=;database=expense_tracking";

        public BindingList<User> Users { get; set; }
    

        public UserViewModel()
        {
            Users = new BindingList<User>();
        }

       // creating user 
        public  void createUser(User user)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "Insert Into user (username, email,  password) Values (@username,@email,@password)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        string passwordHash = HashPassword(user.password);
                        command.Parameters.AddWithValue("@username", user.username);
                        command.Parameters.AddWithValue("@email", user.email);
                        command.Parameters.AddWithValue("@password", user.password);
                        command.ExecuteNonQuery();
                    }
                }
                Users.Add(user);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        public void createAcc(string username,  string email, string password)
        {
            User customer = new User()
            {
                username = username,
                email = email,
                password = password
            };

            createUser(customer);
        }

        //encrypting the password
        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }

        // login database
        public User LoginUser(string email, string password)
        {
            
          try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM user WHERE email = @email";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader.GetString("password");
                                string inputHashedPassword = HashPassword(password);
                                if (hashedPassword == inputHashedPassword)
                                {
                                    User user = new User()
                                    {
                                        id = reader.GetInt32("id"),
                                        username = reader.GetString("username"),
                                        email = reader.GetString("email")
                                    };
                                    return user;
                                }
                            }
                        }
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            return null;
        }


        //updating acc

        public void updateAcc(User user)
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE user SET username = @username, email @email, password = @passhash where id =@Id";
                using(MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    string passhashe = HashPassword(user.password);
                    command.Parameters.AddWithValue("@username", user.username);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@passhash", user.password);
                    command.ExecuteNonQuery();
                }
            }
            int index = Users.IndexOf(user);

            if (index != -1)
            {
                Users[index] = user;
            }
        }

        //delete user
        public void deleteAcc(User user)
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM customers WHERE id = @Id";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Id", user.id);
                    }
                }
                Users.Remove(user);
            }catch(MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
        }
    }
}
