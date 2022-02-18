using BusinessLayer;
using BusinessLayer.WorkOrders;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForce.Controllers
{
 
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var result = "";
            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            UserManager cs = new UserManager(new UserDal());
            cs.checkUser("test", "testc");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}