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
        /// <summary>
        /// 返回所有数据
        /// </summary>
        /// <returns></returns>
        List<T> Select();
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Insert(T t);
        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Update (T t);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Delete(T t);
    }
}
