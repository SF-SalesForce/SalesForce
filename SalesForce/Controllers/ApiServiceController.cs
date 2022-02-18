using BusinessLayer;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalesForce.Controllers
{ 
    public class ApiServiceController : ApiController
    {
        public ApiServiceController()
        {
                
        }
        
        public Tbl_Users CheckUserName(string username, string password)
        {
            UserManager cs = new UserManager(new UserDal());
            Tbl_Users retVal = cs.checkUser(username, password);
            return retVal;

            //return "CheckUserName " + username  + "  " + password;
        }
    }
}
