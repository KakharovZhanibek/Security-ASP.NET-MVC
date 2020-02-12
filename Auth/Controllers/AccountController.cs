using Auth.Interfaces;
using Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider AuthProvider;
        public AccountController()
        {
            AuthProvider = new FormAuthProvider();
        }
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (AuthProvider.Authenticate(user.Login, user.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "My"));
                }
                else
                {
                    ModelState.AddModelError("", "Incorrect login or password");
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

    }
}