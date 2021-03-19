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

        /// <summary>
        /// 檢查登入
        /// </summary>
        /// <returns></returns>
        public void CheckLogin()
        {
            LoginSuccess = Auth();
        }

        /// <summary>
        /// 驗證身份
        /// </summary>
        /// <returns></returns>
        private bool Auth()
        {
            return Name == "abc" && Password == "abc";
        }
    }
}