using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class CustomerCartModel
    {
        public int ID { get; set; }
        //Foreight Key
        public int AccountID { get; set; }
    }
}