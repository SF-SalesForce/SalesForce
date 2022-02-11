using BusinessLayer;
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
        
        public ModelUser CheckUserName(string username, string password)
        {
            UserManagement cs = new UserManagement();
            ModelUser retVal = cs.checkUser(username, password);
            return retVal;

            //return "CheckUserName " + username  + "  " + password;
        }
    }
}
