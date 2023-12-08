using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Interface
{
    /// <summary>
    /// 图书借口
    /// </summary>
    public interface IBookRepository<T> where T : class
    {
        List<T> Select();
        T Find(int Id);
        T Save(T t);
    }
}
