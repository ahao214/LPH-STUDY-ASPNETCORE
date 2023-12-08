using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Domain.Interface
{
    /// <summary>
    /// 历史记录借口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IHistoryRepository<T> where T : class 
    {
        List<T> Select();
        T Find(int Id);
        T Save(T t);
    }
    
}
