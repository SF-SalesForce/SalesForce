using BusinessLayer;
using BusinessLayer.OrderAssigment;
using BusinessLayer.WorkOrders;
using DataAccessLayer;
using DataAccessLayer.Concrete;
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
        WorkOrderManager wom = new WorkOrderManager(new WorkOrdersDal());
        OrderAssigmentManager oa = new OrderAssigmentManager(new OrderAssigmentDal());

       UserManager um = new UserManager(new UserDal());

        public ActionResult WorkOrdersHome()
        {
            var re = wom.WorkOrderTables();
          
           
            return View(re);
            
        }
        public ActionResult NewAssign(int id)
        {
            List<SelectListItem> select = (from x in um.getAllKurye().Where(x => x.UserType == "Kurye")
                                           select new SelectListItem
                                           {
                                               Text = x.UserEmail,
                                               Value = (x.ID).ToString()
                                           }).ToList();
            ViewBag.combobox = select;
            ViewBag.WorkOrderId = id;
            return View();
        }
        [HttpPost]
        public ActionResult NewAssign(Tbl_OrderAssigment p)
        {
            

            oa.AddOrderAssigment(p);
      
            var order = wom.GetByID((int)p.OrderID);
            order.OrderStatus = true;
            wom.UpdateAssign(order);
            return RedirectToAction("WorkOrdersHome");
        }

        public ActionResult UpdateAssign(int id)
        {
            var value = wom.GetByID(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAssign(Tbl_Orders p)
        {
            wom.UpdateAssign(p);
            return RedirectToAction("WorkOrdersHome");
        }

        public ActionResult DeleteAssign(int id)
        {
            
            wom.DeleteAssign(wom.GetByID(id));
            return RedirectToAction("WorkOrdersHome");
        }



    }
}