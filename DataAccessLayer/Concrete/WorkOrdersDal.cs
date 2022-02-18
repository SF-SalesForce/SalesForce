using DataAccessLayer.Abstract;
using DataAccessLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class WorkOrdersDal :GenericDal<Tbl_Orders>,IWorkOrdersDal
    {
        SalesForceEntities db = new SalesForceEntities();
        public List<WorkOrderDto> GetAllDetail()
        {
            var re = (from o in db.Tbl_Orders
                      join od in db.Tbl_OrderDetails on o.ID equals od.OrderID
                      join p in db.Tbl_Products on od.ProductID equals p.ID
                      join c in db.Tbl_Customers on o.CustomerID equals c.ID
                      select new WorkOrderDto { WorkOrderID=o.ID, WorkOrderNumber = (int)o.ID,   ProductName=p.ProductName , Quantity = (int)od.Quantity, Price = (double)p.Price, Adress = c.Adress , OrderDate = (DateTime)o.OrderDate , OrderDelivery = (bool)o.OrderDelivery , OrderStatus = (bool)o.OrderStatus }).ToList();

            return re;
        }
    }
}
