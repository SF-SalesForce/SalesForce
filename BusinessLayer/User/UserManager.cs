using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer;
using DataAccessLayer.Abstract;

namespace BusinessLayer
{
    public class UserManager
    {
        SalesForceEntities db = new SalesForceEntities();
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }





        public Tbl_Users checkUser(string username, string password)
        {
            Tbl_Users result = db.Tbl_Users.SingleOrDefault(p => p.UserEmail == username && p.UserPassword == password);
            Tbl_Users md = new Tbl_Users();
            md.ID = result.ID;
            md.UserType = result.UserType;
            md.UserEmail = result.UserEmail;
            md.UserImagePath = result.UserImagePath;
            return md;
        }


        public List<Tbl_Users> getAllKurye()
        {

            return _userdal.GetAll();
        }

    }
}
