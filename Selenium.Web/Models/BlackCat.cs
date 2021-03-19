using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Selenium.Web.Models
{
    public class BlackCat : ILogistics
    {
        private double _fee;
        private readonly string _companyName = "黑貓";

        public void Calculate()
        {
            ////頁面呈現物流商名稱
            //this.lblCompany.Text = "黑貓";

            ////頁面取值
            //var weight = Convert.ToDouble(this.txtProductWeight.Text);

            ////計算運費邏輯
            //if (weight > 20)
            //{
            //    //頁面呈現計算的運費結果
            //    this.lblCharge.Text = "500";
            //}
            //else
            //{
            //    //頁面呈現計算的運費結果
            //    var fee = 100 + weight * 10;
            //    this.lblCharge.Text = fee.ToString();
            //}

            var weight = ShipProduct.Weight;

            //計算運費邏輯
            if (weight > 20)
            {
                _fee = 500;
            }
            else
            {
                //頁面呈現計算的運費結果
                var fee = 100 + weight * 10;
                _fee = fee;
            }
        }

        public Product ShipProduct { get; set; }

        public string GetsComapanyName()
        {
            return _companyName;
        }

        public double GetsFee()
        {
            return _fee;
        }
    }
}