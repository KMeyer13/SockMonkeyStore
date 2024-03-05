using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            command.CommandType=System.Data.CommandType.StoredProcedure;
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
            //return (IEnumerable<Product>)_dbContext.Products.OrderBy(p => p.Name);
            throw new NotImplementedException();
        }

        public CategoryModel GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public ProductModel GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductData.GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}