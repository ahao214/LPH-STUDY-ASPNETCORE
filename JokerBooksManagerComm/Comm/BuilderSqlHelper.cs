using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// SQL语句生成帮助类
    /// </summary>
    public class BuilderSqlHelper
    {
        #region 
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string InsertSql<T>(T t, string tableName) where T : class
        {
            // 第一步是判断传入的T是否位null或者传入的表名是否位空
            if (t == null || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            // 获取需要的列名
            string colNames = GetColumnName<T>(t);
            return colNames;
        }
        #endregion

        #region 
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        private static string GetColumnName<T>(T t)
        {
            // 链式写法
            Type type = typeof(T);
            return string.Join(",", type.GetType().GetProperties().Select(p => p.Name).ToArray());

        } 
        #endregion

    }
}
