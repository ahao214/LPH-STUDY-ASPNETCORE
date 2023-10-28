using System.Collections.Generic;
using T2.Models;

namespace T2.Utils
{
    interface IProductService
    {
        IEnumerable<Goods> GetAllGoods();

    }
}
