using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class CustomerCartItemModel
    {
        public int ID { get; set; }
        public int CardID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}