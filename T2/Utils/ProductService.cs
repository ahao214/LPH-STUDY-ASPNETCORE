using System.Collections.Generic;
using T2.Models;

namespace T2.Utils
{
    public class ProductService : IProductService
    {
        public IEnumerable<Goods> GetAllGoods()
        {
            return new List<Goods>()
            {
               new Goods(1,"苹果",10),
               new Goods(2,"凤梨",12),
               new Goods(3,"橘子",23),
               new Goods(4,"香蕉",4),

            };
        }
    }
}
