using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Selenium.Web.Models
{
    public class HsinChu : ILogistics
    {
        private double _fee;
        private readonly string _companyName = "新竹貨運";

        public void Calculate()
        {
            ////頁面呈現物流商名稱
            //this.lblCompany.Text = "新竹貨運";

            ////頁面取值
            //var length = Convert.ToDouble(this.txtProductLength.Text);
            //var width = Convert.ToDouble(this.txtProductWidth.Text);
            //var height = Convert.ToDouble(this.txtProductHeight.Text);

            //var size = length * width * height;

            ////計算運費邏輯
            ////長 x 寬 x 高（公分）x 0.0000353
            //if (length > 100 || width > 100 || height > 100)
            //{
            //    //頁面呈現計算的運費結果
            //    this.lblCharge.Text = (size * 0.0000353 * 1100 + 500).ToString();
            //}
            //else
            //{
            //    //頁面呈現計算的運費結果
            //    this.lblCharge.Text = (size * 0.0000353 * 1200).ToString();
            //}

            var size = ShipProduct.Size.Length * ShipProduct.Size.Width * ShipProduct.Size.Height;

            if (ShipProduct.Size.Length > 100 || ShipProduct.Size.Width > 100 || ShipProduct.Size.Height > 100)
            {
                _fee = size * 0.0000353 * 1100 + 500;
            }
            else
            {
                _fee = size * 0.0000353 * 1200;
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