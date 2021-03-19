namespace Selenium.Web.Models
{
    public class Product
    {
        /// <summary>
        /// 產品名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// 體積
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// 需冷藏
        /// </summary>
        public bool IsNeedCool { get; set; }
    }
}