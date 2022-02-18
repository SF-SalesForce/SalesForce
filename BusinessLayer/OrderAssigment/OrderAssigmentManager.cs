using DataAccessLayer;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.OrderAssigment
{
    public class OrderAssigmentManager
    {
        IOrderAssigmentDal _orderAssigmentDal;

        public OrderAssigmentManager(IOrderAssigmentDal orderAssigmentDal)
        {
            _orderAssigmentDal = orderAssigmentDal;
        }


        public void AddOrderAssigment(Tbl_OrderAssigment orderAssigment)
        {
            _orderAssigmentDal.Add(orderAssigment);
        }


        


    }
}
