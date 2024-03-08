using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace SockMonkeyStore.Models
{
    public interface ITestAccount : IPrincipal
    {
        //IIdentity Identity { get; }

        //bool IsInRole { get; }
        int ID { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
}