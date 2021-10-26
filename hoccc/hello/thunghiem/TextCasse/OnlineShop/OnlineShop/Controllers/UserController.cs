using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Controllers
{
    public class UserController : Controller
    {
        public static bool Check = false;
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult adminLogin(string Account, string Password)
        {
            if (Account == "admin" && Password == "1234")
            {
                Check = true;
                HttpContext.Session.SetString("admin_login", "Administrator");
                return Redirect("/Product/Index");
            }
            else if (Account == "user" && Password == "1234")
            {
                Check = true;
                HttpContext.Session.SetString("user_login", "User");                
                return Redirect("/Shop/Index");
            }
            else
            {
                Check = false;
                TempData["error_login"] = "Tài khoản hoặc mật khẩu không chính xác";
                return RedirectToAction("Login");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Remove("admin_login");
            return RedirectToAction("Login");
        }
    }
}