using BusinessLayer;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForce.Controllers
{
    public class UserController : Controller
    {

        // GET: User

        public ActionResult UserLogin()
        {
            //var result = um.checkUser(username, password);
            return View();
        }


        [HttpPost]
        public JsonResult CheckUserNamePassword(string UserName, string UserPassword)
        {
            UserManager um = new UserManager(new UserDal());
            var result = um.checkUser(UserName, UserPassword);

            Session["UserType"] = result.UserType;
            Session["UserID"] = result.ID;
            Session["UserName"] = result.UserEmail;
            Session["UserImagePath"] = result.UserImagePath;


            return Json(result);
        }


        public ActionResult UserLogout()
        {
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("UserLogin");

        }


    }
}