using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dto
{
    public class WorkOrderDto
    {
        public int WorkOrderID { get; set; }
        public int WorkOrderNumber { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Adress { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderDelivery { get; set; }
        public bool OrderStatus { get; set; }
    }
}
