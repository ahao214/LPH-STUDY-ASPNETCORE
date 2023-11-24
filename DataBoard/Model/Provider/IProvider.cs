using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBoard.Model.Provider
{
    /// <summary>
    /// 方法接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IProvider<T> where T : class
    {
        List<T> Select();
        int Insert(T t);
        int Update (T t);
        int Delete(T t);
    }
}
