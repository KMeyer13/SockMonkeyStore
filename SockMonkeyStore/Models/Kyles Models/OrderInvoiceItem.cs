using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public partial class OrderInvoiceItem
    {
        public int ID { get; set; }
        public int InvoiceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; }

        public virtual OrderInvoice Invoice { get; set; }
    }
}