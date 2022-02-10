//using DataAccessLayer;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessLayer
//{
//    public class BaseManager 
//    {
//        SalesForceEntities db =new SalesForceEntities();
//        public List<Tbl_Customers> getAll()
//        {
//            return db.Tbl_Customers.ToList();
//        }

//        public Tbl_Users (string username,string password)
//        {
//            var result = db.Tbl_Users.SingleOrDefault(p=>p.UserEmail == username && p.UserPassword ==password );
//            return result;
//        }

//    }
//}
