using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
   public class ModelOppurtunity 
    {
       

        public int ID { get; set; }
        public string OppurtunityType { get; set; }
        public string OppurtunityHeader { get; set; }

        public string OppurtunityDetail { get; set; }
        
        public string OppurtunityCustomerName { get; set; }

        public string OppurtunityCustomerAdress { get; set; }

        public DateTime OppurtunityExpireDate { get; set; }

        public string OppurtunityEntery { get; set; }
        public string OppurtunityDescription { get; set; }

        public DateTime OppurtunityStartDate { get; set; }




    }
}
