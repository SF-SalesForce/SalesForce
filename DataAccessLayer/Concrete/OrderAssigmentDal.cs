using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class OrderAssigmentDal : GenericDal<Tbl_OrderAssigment>,IOrderAssigmentDal
    {
    }
}
