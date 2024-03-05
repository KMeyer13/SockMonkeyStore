using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class OrderInvoiceItemModel
    {
        public int ID { get; set; }
        //Foreign Key
        public string InvoiceID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }
    }
}