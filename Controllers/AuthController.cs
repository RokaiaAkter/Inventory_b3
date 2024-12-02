using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_b3.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
         //POST: Auth/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {

            if (username == "Admin" && password == "123")
            {
                Session["username"] = username;
                ViewBag.Msg = "Login Success";
                //Redirect to a secured page after successful login
                //return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.Msg = "Login Failed.";
                //return View(); 
            }
            return View();

           
        }
        // Action method for handling Logout
       [ HttpPost]
        public ActionResult Logout()
        {
            // Clear user session or cookies if needed
            Session.Remove("username");
            return RedirectToAction("Login");
        }
    }
}