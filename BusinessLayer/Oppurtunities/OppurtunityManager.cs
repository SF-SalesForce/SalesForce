using BusinessLayer;
using DataAccessLayer.Models;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Oppurtunities
{
    public class OppurtunityManager 
    {
        IOppurtunityDal _oppurtunityDal;
        public OppurtunityManager(IOppurtunityDal oppurtunityDal)
        {
            _oppurtunityDal = oppurtunityDal;
        }
        public List<Tbl_Oppurtunity> GetAll()
        {
            return _oppurtunityDal.GetAll();
        }


        //List<ModelOppurtunity> getAllOppurtunity()
        //{
        //    var dbset = db.Tbl_Oppurtunity.ToList();
        //    List<ModelOppurtunity> oppurtunitiyList = new List<ModelOppurtunity>();
        //    foreach (var item in dbset)
        //    {
        //        oppurtunitiyList.Add(new ModelOppurtunity
        //        {
        //            ID = item.ID,
        //            OppurtunityCustomerAdress = item.OppurtunityCustomerAdress,
        //            OppurtunityCustomerName = item.OppurtunityCustomerName,
        //            OppurtunityDescription = item.OppurtunityDescription,
        //            OppurtunityDetail = item.OppurtunityDetail,
        //            OppurtunityEntery = item.OppurtunityEntery,
        //            OppurtunityExpireDate = (DateTime)item.OppurtunityExpireDate,
        //            OppurtunityHeader = item.OppurtunityHeader,
        //            OppurtunityStartDate = (DateTime)item.OppurtunityStartDate,
        //            OppurtunityType = item.OppurtunityType

        //        });
        //        // x.Add(new ModelWorkOrders { ID = 1, OrderNumber = "12", UserMail = "kurye1@gmail.com" });
        //    }
        //    return oppurtunitiyList;


        //}
    }
}
