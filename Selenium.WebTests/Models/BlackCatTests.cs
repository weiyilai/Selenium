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
    public class BlackCatTests
    {
        [TestMethod()]
        public void GetsComapanyNameTest()
        {
            BlackCat target = new BlackCat();
            string expected = "黑貓";
            string actual;
            actual = target.GetsComapanyName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetsFeeTest()
        {
            BlackCat target = new BlackCat();
            double expected = 0F;
            double actual;
            actual = target.GetsFee();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateTest()
        {
            // 從整合測試的test case，來當做單元測試的test case

            // arrange
            BlackCat target = new BlackCat()
            {
                ShipProduct = new Product
                {
                    IsNeedCool = true,
                    Name = "商品測試1",
                    Size = new Size
                    {
                        Height = 10,
                        Length = 30,
                        Width = 20
                    },
                    Weight = 10
                }
            };

            // act
            target.Calculate();

            var expectedName = "黑貓";
            var expectedFee = 200;

            var actualName = target.GetsComapanyName();
            var actualFee = target.GetsFee();

            // assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedFee, actualFee);
        }
    }
}