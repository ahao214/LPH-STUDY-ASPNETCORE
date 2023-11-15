namespace EBusiness.Service.Models
{
    /// <summary>
    /// 商品MongoDB配置选项
    /// </summary>
    public class ProductMongoDBOptions
    {
        /// <summary>
        /// 商品集合名
        /// </summary>
        public string ProductCollectionName { get; set; }
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string CollectionString { get; set; }
        /// <summary>
        /// 商品数据库名
        /// </summary>
        public string DatabaseName { get; set; }

    }
}
