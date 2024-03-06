using SockMonkeyStore.Models;
using SockMonkeyStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SockMonkeyStore.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductData db;

        public ProductController(IProductData db)
        {
            this.db = db;
        }
        // GET: Product
        public ActionResult Index()
        {
            var items = db.GetAllProducts();
            //var product = new Product();
            //product.ID = 1;
            //product.Name = "Test Monkey";
            //product.Description = "Test Monkey description of the sock monkey";
            //product.Price = 15.00M;
            //product.Quantity = 3;
            //product.ImagePath = "https://i5.walmartimages.com/seo/Plushland-Adorable-Sock-Monkey-8-Inches-Tall-Soft-Realistic-Plush-Knitted-Stuffed-Animal-Toy-Gift-for-Kids-Babies-Teens-Girls-and-Boys-Brown_bb110d71-ddcd-4fda-9de3-c65376a8b3da.c7fe8f451f19207f45d274aa4c112d34.jpeg?odnHeight=640&odnWidth=640&odnBg=FFFFFF";
            //items.Add(product);
            return View(items);
        }

        public ActionResult ProductByCategory(int Id)
        {
            var items = db.GetProductsByCategory(Id);
            return View(items);
        }
    }
}