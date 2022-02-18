using BusinessLayer;
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
        public void AddOppurtunity(Tbl_Oppurtunity Oppurtunity)
        {
            _oppurtunityDal.Add(Oppurtunity);
        }
        public void UpdateOppurtunity(Tbl_Oppurtunity Oppurtunity)
        {
            _oppurtunityDal.Update(Oppurtunity);
        }
        public void DeleteOppurtunity(Tbl_Oppurtunity Oppurtunity)
        {
            _oppurtunityDal.Delete(Oppurtunity);
        }
        public Tbl_Oppurtunity GetByID(int id)
        {
            return _oppurtunityDal.GetByID(x => x.ID == id);
        }
        #region MyRegion
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
        #endregion
    }
}
