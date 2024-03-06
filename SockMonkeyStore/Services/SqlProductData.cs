using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Services
{
    public class SqlProductData : IProductData
    {
        //private readonly Models.TrainingProjectEntities _dbContext; //Models\Model1.Context.cs

        //public SqlProductData(TrainingProjectEntities dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        public IEnumerable<Category> GetAllCategories()
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Category].[gt_Category]", connection);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            var response = new List<Category>();
            while (reader.Read())
            {
                var category = new Category();
                category.ID = Convert.ToInt32(reader["CategoryID"]);
                category.CategoryName = reader["CategoryName"].ToString();
                category.CategorySlug = reader["CategorySlug"].ToString();
                response.Add(category);
            }

            return response;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Product].[gt_Product]", connection);
            command.CommandType = CommandType.StoredProcedure;
            var reader = command.ExecuteReader();
            var response = new List<Product>();
            while (reader.Read())
            {
                var product = new Product();
                product.ID = Convert.ToInt32(reader["ID"]);
                product.Name = reader["Name"].ToString();
                product.Description = reader["Description"].ToString();
                product.Price = Convert.ToDecimal(reader["Price"]);
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.ImagePath = reader["ImagePath"].ToString();
                response.Add(product);
            }

            return response;
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            SqlConnection connection = new SqlConnection("Data Source=d-playground01,5167;Initial Catalog=TrainingProject;Persist Security Info=True;User ID=sa;Password=43KdqA#56;Application Name=Kyles App");
            connection.Open();
            SqlCommand command = new SqlCommand("[Product].[gt_ProductByCategory]", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("categoryID", categoryId);
            var reader = command.ExecuteReader();
            var response = new List<Product>();
            while (reader.Read())
            {
                var product = new Product();
                product.ID = Convert.ToInt32(reader["ProductID"]);
                product.Name = reader["Name"].ToString();
                product.Description = reader["Description"].ToString();
                product.Price = Convert.ToDecimal(reader["Price"]);
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.ImagePath = reader["ImagePath"].ToString();
                response.Add(product);
            }

            return response;
        }
    }
}