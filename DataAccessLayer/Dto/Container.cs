using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dto
{
    public class Container
    {
        public Tbl_Orders tbl_Orders { get; set; }
        public Tbl_OrderDetails Tbl_OrderDetails { get; set; }
        public Tbl_Products tbl_Products { get; set; }
        public Tbl_Customers tbl_Customers { get; set; }
    }
}
