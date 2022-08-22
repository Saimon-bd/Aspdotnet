using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginPanel1
{
    public class LoginManager34
    {
        LoginUserGateway34 aLoginUserGateway = new LoginUserGateway34();
        //public UserLogin GetUserDetails(string userId)
        //{
        //    return aLoginUserGateway.GetUserDetail(userId);
        //}

        public UserLogin LoginUser(string userName, string passward)
        {
            return aLoginUserGateway.LoginUser(userName, passward);
        }
    }
}