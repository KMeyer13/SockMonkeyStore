using SockMonkeyStore.Models;
using SockMonkeyStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SockMonkeyStore.Controllers
{
    public class HomeController : Controller
    {
        readonly IProductData db;
        
        public HomeController(IProductData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var categories = db.GetAllCategories();
            //var categories = new List<Category>();
            return View(categories);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}