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
        /// 获取SQL的插入语句
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型变量</param>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键ID</param>
        /// <returns></returns>
        public static string InsertSql<T>(T t, string tableName, string primaryKey) where T : class
        {
            // 第一步是判断传入的T是否位null或者传入的表名是否位空
            if (t == null || string.IsNullOrEmpty(tableName))
            {
                return string.Empty;
            }
            // 获取需要的列名
            string colNames = GetColumnName<T>(t, primaryKey);
            return colNames;
        }
        #endregion

        #region 通过反射获取到T型的列

        /// <summary>
        /// 通过反射获取到T型的列
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型参数</param>
        /// <param name="primaryKey">主键ID</param>
        /// <returns>返回由逗号构成的列</returns>
        private static string GetColumnName<T>(T t, string primaryKey)
        {
            // 链式写法
            return string.Join(",", t.GetType().GetProperties().Where(p => p.Name != primaryKey).Select(p => p.Name).ToArray());
        }
        #endregion

    }
}
