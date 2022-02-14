using BusinessLayer.Oppurtunities;
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
        public ActionResult OppurtunityIndex()
        {
            var re = om.GetAll();
            return View(re);
        }
    }
}