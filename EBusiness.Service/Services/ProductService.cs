using EBusiness.Service.Models;
using System.Collections.Generic;
using EBusiness.Service.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace EBusiness.Service.Services
{
    /// <summary>
    /// 商品服务
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _products;
        private readonly IConfiguration _configuration;

        public ProductService(/*IConfiguration configuration*/ IOptions<ProductMongoDBOptions> options)
        {
            ProductMongoDBOptions productMongoDBOptions = options.Value;
            //1 建立MongoDB连接
            var client = new MongoClient(productMongoDBOptions.CollectionString);

            //2 获取商品库
            var database = client.GetDatabase(productMongoDBOptions.DatabaseName);

            //3 获取商品表(集合)
            _products = database.GetCollection<Product>(productMongoDBOptions.ProductCollectionName);
        }

        public void Create(Product product)
        {
            _products.InsertOne(product);
        }

        public void Delete(Product product)
        {
            _products.DeleteOne(p => p.Id == product.Id);
        }

        public Product GetProductById(string id)
        {
            return _products.Find<Product>(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _products.Find(p => true).ToList();
        }

        public bool ProductExists(int id)
        {
            return false;
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
