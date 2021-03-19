using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Selenium.Web.Models
{
    public class LoginModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool LoginSuccess { get; set; }

        public bool CheckLogin()
        {
            if (Name == "abc" && Password == "abc")
            {
                LoginSuccess = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}