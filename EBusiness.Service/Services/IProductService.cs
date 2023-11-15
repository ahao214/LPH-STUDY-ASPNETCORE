using EBusiness.Service.Models;
using System.Collections.Generic;

namespace EBusiness.Service.Services
{
    /// <summary>
    /// 商品服务接口
    /// </summary>
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        bool ProductExists(int id);


    }
}
