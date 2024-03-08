using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SockMonkeyStore.Models
{
    public class TestAccount : ITestAccount
    {
        public IIdentity Identity => new GenericIdentity(string.Empty);

        public bool IsInRole(string role) => false;

        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}