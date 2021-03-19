using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.Web.Models.Tests
{
    [TestClass()]
    public class LogisticsTests
    {
        [TestMethod()]
        public void GetILogisticsTest_GetBlackCat()
        {
            // arrange
            string p = "1";
            Product product = new Product();
            ILogistics expected = new BlackCat();

            ILogistics actual;

            // act
            actual = SimpleFactory.GetILogistics(p, product);

            // assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetILogisticsTest_Get新竹貨運()
        {
            // arrange
            string p = "2";
            Product product = new Product();
            ILogistics expected = new HsinChu();

            ILogistics actual;

            // act
            actual = SimpleFactory.GetILogistics(p, product);

            // assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetILogisticsTest_Get郵局()
        {
            //arrange
            string p = "3";
            Product product = new Product();
            ILogistics expected = new PostOffice();

            ILogistics actual;

            //act
            actual = SimpleFactory.GetILogistics(p, product);

            //assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }
    }
}