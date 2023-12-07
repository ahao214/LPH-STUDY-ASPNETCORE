using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Demo.Dao
{
    /// <summary>
    /// 基础接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IProvider<T>
    {
        List<T> Select();
        T Select(int Id);
        int Insert(T t);
        int Update(T t);
        int Delete(T t);

    }
}
