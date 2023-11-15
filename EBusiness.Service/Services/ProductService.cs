using EBusiness.Service.Models;
using System.Collections.Generic;
using EBusiness.Service.Models;
using MongoDB.Driver;

namespace EBusiness.Service.Services
{
    /// <summary>
    /// 商品服务
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _products;


        public ProductService()
        {
            //1 建立MongoDB连接
            var client = new MongoClient("mongodb://localhost:27017");

            //2 获取商品库
            var database = client.GetDatabase("productdb");

            //3 获取商品表(集合)
            _products = database.GetCollection<Product>("Product");
        }

        public void Create(Product product)
        {
            _products.InsertOne(product);
        }

        public void Delete(Product product)
        {
            _products.DeleteOne(p => p.Id == product.Id);
        }

        public Product GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public bool ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
