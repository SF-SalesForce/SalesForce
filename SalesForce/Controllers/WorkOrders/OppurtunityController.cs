using BusinessLayer.Oppurtunities;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForce.Controllers.WorkOrders
{
    public class OppurtunityController : Controller
    {
        // GET: Oppurtunity
        OppurtunityManager om = new OppurtunityManager(new OppurtunityDal());
        public ActionResult OppurtunityHome()
        {
            var re = om.GetAll();
            return View(re);
        }

        public ActionResult NewOppurtunity()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewOppurtunity(Tbl_Oppurtunity p)
        {
            om.AddOppurtunity(p);
            return RedirectToAction("OppurtunityHome");
        }

        public ActionResult UpdateOppurtunity(int id)
        {
            var value = om.GetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateOppurtunity(Tbl_Oppurtunity p)
        {
            om.UpdateOppurtunity(p);
            return RedirectToAction("OppurtunityHome");
        }
        public ActionResult DeleteOppurtunity(int id)
        {
            om.DeleteOppurtunity(om.GetByID(id));
            return RedirectToAction("OppurtunityHome");
        }

    }
}