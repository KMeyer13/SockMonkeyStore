using SockMonkeyStore.Models;
using SockMonkeyStore.Services;
using System;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;

namespace SockMonkeyStore.Controllers
{
    public class AccountController : Controller
    {
        readonly CustomerData db;
        ITestAccount testAccount;

        public AccountController(CustomerData db, ITestAccount testAccount)
        {
            this.db = db;
            this.testAccount = testAccount; 
        }
        // GET: Account
        public ActionResult Index()
        {
            var x = testAccount;
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

        public ActionResult BillingProfileView()
        {
            return View();
        }

        public ActionResult ShippingProfileView()
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
                newUser.Password = newAccount.Password;
                return SignIn(newUser);
            }
            return View(newAccount);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(AccountSignInViewModel newSignIn)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Login Failed");
                return View(newSignIn);
            }
            var signedInUser = db.SignIn(newSignIn.Email);
            var verified = Crypto.VerifyHashedPassword(signedInUser.PasswordHash, newSignIn.Password);
            TestAccount account = new TestAccount();
            if (verified)
            {
                
                account.Email = signedInUser.Email;
                account.FirstName = signedInUser.FirstName;
                account.LastName = signedInUser.LastName;
                account.ID = signedInUser.ID;

                //return RedirectToAction("Index");
            }

            var ticket = new FormsAuthenticationTicket(
                1,
                "KyleAuth",
                DateTime.Now,
                DateTime.Now.AddDays(1),
                true,
                $"Account: {account.ID} Email: {account.Email}"
                );
            string encTicket = FormsAuthentication.Encrypt(ticket);
            var cookie = FormsAuthentication.GetAuthCookie(
                        "KyleAuth", true);
            cookie.Name = "KyleAuth";
            cookie.Value = encTicket;
            HttpContext.Response.Cookies.Add(cookie);

            return View(newSignIn);
        }
    }
}