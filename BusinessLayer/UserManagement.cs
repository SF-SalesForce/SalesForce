using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using DataAccessLayer;

namespace BusinessLayer
{
   public class UserManagement
    {
        SalesForceEntities db = new SalesForceEntities();

        public ModelUser checkUser(string username, string password)
        {
            Tbl_Users  result = db.Tbl_Users.SingleOrDefault(p => p.UserEmail == username && p.UserPassword == password);
            ModelUser md = new ModelUser();
            md.ID = result.ID.ToString();
            md.UserType = result.UserType;
            md.UserEmail = result.UserEmail;
            md.UserImagePath = result.UserImagePath;
            return md;
        }

    }
}
