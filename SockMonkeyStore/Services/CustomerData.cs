using SockMonkeyStore.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SockMonkeyStore.Services
{
    public class CustomerData
    {
        public void CreateAccount(Account account)
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Customer].[mw_Account_Insert]", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Email", account.Email);
            command.Parameters.AddWithValue("PasswordHash", account.PasswordHash);
            command.Parameters.AddWithValue("FirstName", account.FirstName);
            command.Parameters.AddWithValue("LastName", account.LastName);
            command.Parameters.AddWithValue("Phone", account.Phone);
            command.ExecuteNonQuery();
            return;
        }

        public Account SignIn(string email)
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Customer].[gt_Account]", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Email", email);
            var reader = command.ExecuteReader();
            Account user = new Account();
            while (reader.Read())
            {
                user.PasswordHash = reader["PasswordHash"].ToString();
                user.FirstName = reader["FirstName"].ToString();
                user.LastName = reader["LastName"].ToString();
                user.Email = reader["Email"].ToString();
                user.ID = Convert.ToInt32(reader["ID"]);
            }

            return user;
        }
    }
}
