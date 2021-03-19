using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Selenium.Web.Models
{
    public class SimpleFactory
    {
        /// <summary>
        /// 將ILogistics的instance，交給工廠來決定
        /// </summary>
        /// <param name="p"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public static ILogistics GetILogistics(string company, Product product)
        {
            if (company == "1")
            {
                return new BlackCat() { ShipProduct = product };
            }
            else if (company == "2")
            {
                return new HsinChu() { ShipProduct = product };
            }
            else if (company == "3")
            {
                return new PostOffice() { ShipProduct = product };
            }
            else
            {
                return null;
            }
        }
    }
}