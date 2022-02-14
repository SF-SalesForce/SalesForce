using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.WorkOrders
{
    public class WorkOrderManagement
    {
        SalesForceEntities db = new SalesForceEntities();
        public List<ModelWorkOrders> WorkOrderList(string UserMail)
        {

            //var result = db.vw_orders.Select(x => x.UserEmail == UserMail);
            List<ModelWorkOrders> x = new List<ModelWorkOrders>();
            x.Add(new ModelWorkOrders { ID = 1, OrderNumber = "12", UserMail = "kurye1@gmail.com" });
            x.Add(new ModelWorkOrders { ID = 2, OrderNumber = "3", UserMail = "kurye2@gmail.com" });

            return x;
        }
    }
}
