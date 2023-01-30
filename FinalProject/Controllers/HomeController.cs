using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool isValidUser = _dbContext.Users
                    .All(u => u.UserName.ToLower() == user
                    .userName.ToLower() && user
                    .password == user.password);

                if (isValidUser)
                {
                    FormsAuthentication.SetAuthCookie(user.userName, false);
                    return RedirectToAction("Index", "Employees");
                }
            }

            ModelState.AddModelError("", "Invalid Username or Password");
            return View();

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}