using BusinessLayer.WorkOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesForce.Controllers.WorkOrders
{
    public class WorkOrderController : Controller
    {
        // GET: WorkOrder
        WorkOrderManagement wom = new WorkOrderManagement();
        public ActionResult Index()
        {
            var result=wom.WorkOrderList(Session["UserName"].ToString());
            return View(result);
        }
    }
}