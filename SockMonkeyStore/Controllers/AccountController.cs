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
        [ValidateAntiForgeryToken]  
        public ActionResult CreateAccount(CreateAccountViewModel newAccount)
        {
            if (ModelState.IsValid)
            {
                var user = new Account();
                user.FirstName = newAccount.FirstName;
                user.LastName = newAccount.LastName;
                user.Email = newAccount.Email;
                user.Phone = newAccount.Phone;
                user.PasswordHash = Crypto.HashPassword(newAccount.Password);
                db.CreateAccount(user);
                //auto log in once created
                var newUser = new AccountSignInViewModel();
                newUser.Email = newAccount.Email;
                newUser.Password=newAccount.Password;
                return SignIn(newUser);
            }
            return View(newAccount);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(AccountSignInViewModel newSignIn)
        {
            if(ModelState.IsValid) { 
                var PasswordHash = db.SignIn(newSignIn.Email);
                var verified = Crypto.VerifyHashedPassword(PasswordHash, newSignIn.Password);
                if(verified)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Login Failed");
            }
            return View(newSignIn);  
        }
    }
}