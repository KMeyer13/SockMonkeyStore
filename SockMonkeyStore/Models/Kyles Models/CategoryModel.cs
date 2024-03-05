using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string CategorySlug { get; set; }
    }
}