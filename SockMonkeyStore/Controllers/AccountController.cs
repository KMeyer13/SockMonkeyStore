using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SockMonkeyStore.Models;
using System.Web.Mvc;
using SockMonkeyStore.Services;
using System.Web.Helpers;

namespace SockMonkeyStore.Controllers
{
    public class AccountController : Controller
    {
        readonly CustomerData db;

        public AccountController(CustomerData db)
        {
            this.db = db;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(CreateAccountViewModel newAccount)
        {
            var user = new Account();
            user.FirstName = newAccount.FirstName;
            user.LastName = newAccount.LastName;
            user.Email = newAccount.Email;
            user.Phone = newAccount.Phone;
            user.PasswordHash = CryptoHelper.Crypto.HashPassword(newAccount.Password);
            db.CreateAccount(user);
            return RedirectToAction("SignIn");
        }
        [HttpPost]
        public ActionResult SignIn(AccountSignInViewModel newSignIn)
        {
            var success = db.SignIn(newSignIn.Email, newSignIn.Password);
            if(!success)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}