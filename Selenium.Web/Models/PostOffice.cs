using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Selenium.Web.Models
{
    public class PostOffice : ILogistics
    {
        private double _fee;
        private readonly string _companyName = "郵局";

        public void Calculate()
        {
            ////頁面呈現物流商名稱
            //this.lblCompany.Text = "郵局";

            ////頁面取值
            //var weight = Convert.ToDouble(this.txtProductWeight.Text);
            //var feeByWeight = 80 + weight * 10;

            //var length = Convert.ToDouble(this.txtProductLength.Text);
            //var width = Convert.ToDouble(this.txtProductWidth.Text);
            //var height = Convert.ToDouble(this.txtProductHeight.Text);
            //var size = length * width * height;
            //var feeBySize = size * 0.0000353 * 1100;

            ////計算運費邏輯
            //if (feeByWeight < feeBySize)
            //{
            //    //頁面呈現計算的運費結果
            //    this.lblCharge.Text = feeByWeight.ToString();
            //}
            //else
            //{
            //    //頁面呈現計算的運費結果
            //    this.lblCharge.Text = feeBySize.ToString();
            //}

            var weight = ShipProduct.Weight;
            var feeByWeight = 80 + weight * 10;
            var size = ShipProduct.Size.Length * ShipProduct.Size.Width * ShipProduct.Size.Height;
            var feeBySize = size * 0.0000353 * 1100;

            if (feeByWeight < feeBySize)
            {
                //頁面呈現計算的運費結果
                _fee = feeByWeight;
            }
            else
            {
                //頁面呈現計算的運費結果
                _fee = feeBySize;
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