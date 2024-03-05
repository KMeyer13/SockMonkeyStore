using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public partial class CustomerCartItem
    {
        public int ID { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual CustomerCart CustomerCart { get; set; }
        public virtual Product Product { get; set; }
    }
}