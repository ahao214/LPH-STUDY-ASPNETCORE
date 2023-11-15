namespace EBusiness.Service.Models
{
    /// <summary>
    /// 产品模型
    /// </summary>
    public class Product
    {

        public string Id { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 商品主图
        /// </summary>
        public string ProductUrl { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        public string ProductTitle { get; set; }
        /// <summary>
        /// 图文描述
        /// </summary>
        public string ProductDescription { get; set; }
        /// <summary>
        /// 商品虚拟价格
        /// </summary>
        public decimal ProductVirtualPrice { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public decimal ProductPrice { get; set; }
        /// <summary>
        /// 商品序号
        /// </summary>
        public int ProductSort { get; set; }
        /// <summary>
        /// 已售件数
        /// </summary>
        public int ProductSold { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int ProductStock { get; set; }
        /// <summary>
        /// 商品状态
        /// </summary>
        public string ProductStatus { get; set; }



    }
}
