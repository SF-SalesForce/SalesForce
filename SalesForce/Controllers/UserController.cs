using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForce.Controllers
{
    public class UserController : Controller
    {
        UserManagement um = new UserManagement();
        // GET: User
        public ActionResult Index(string username,string password)
        {
            var result = um.checkUser(username, password);
            return View(result);
        }
    }
}