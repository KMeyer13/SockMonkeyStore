using SockMonkeyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMonkeyStore.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProduct(int id);

        Category GetCategory(int id);
        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Category> GetAllCategories();
    }
}
