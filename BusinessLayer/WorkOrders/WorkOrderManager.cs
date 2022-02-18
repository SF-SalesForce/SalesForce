using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.WorkOrders
{
    public class WorkOrderManager
    {
        IWorkOrdersDal _workOrdersDal;
        
      
        public WorkOrderManager(IWorkOrdersDal workOrdersDal)
        {
            _workOrdersDal = workOrdersDal;
            
        }

        public List<Tbl_Orders> GetAll()
        {
            return _workOrdersDal.GetAll();
        }
        public void AddAssign(Tbl_Orders workOrders)
        {
            _workOrdersDal.Add(workOrders);
        }
        public void UpdateAssign(Tbl_Orders workOrders)
        {
            _workOrdersDal.Update(workOrders);
        }
        public Tbl_Orders GetByID(int id)
        {
            return _workOrdersDal.GetByID(x => x.ID == id);
        }

        public void DeleteAssign(Tbl_Orders orders)
        {
            _workOrdersDal.Delete(orders);
        }



        public List<WorkOrderDto> WorkOrderTables ()
        {
            return _workOrdersDal.GetAllDetail();
        }

        //SalesForceEntities db = new SalesForceEntities();
        //public List<Tbl_Orders> GetAllDetail()
        //{
        //    return db.Tbl_Orders.Include(x => x.Tbl_WorkOrders).ToList();
        //}
    }
}
