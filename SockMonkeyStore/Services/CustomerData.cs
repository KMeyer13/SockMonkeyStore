using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Web.Helpers;

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

        public string SignIn(string email)
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Customer].[gt_Account]", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Email", email);
            var reader = command.ExecuteReader();
            string passwordHash = "";
            while(reader.Read())
            {
               passwordHash = reader["PasswordHash"].ToString();
            }

            return passwordHash;
        }
    }
}
