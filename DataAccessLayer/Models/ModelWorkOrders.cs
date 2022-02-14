using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class ModelWorkOrders
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string OrderNumber { get; set; }
        public string UserMail { get; set; }

    }
}
