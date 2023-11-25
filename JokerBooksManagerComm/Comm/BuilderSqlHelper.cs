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

            // 得到列对应的值
            string fieldValues = GetFieldValue<T>(t, primaryKey);
            // 拼接字符串
            StringBuilder sb = new StringBuilder();
            sb.Append($"INSERT INTO {tableName}");
            sb.Append($"({colNames})");
            sb.Append($" VALUES {fieldValues}");

            return sb.ToString();
        }
        #endregion

        #region 通过反射获取到T型的列(这里主要是Model类)

        /// <summary>
        /// 通过反射获取到T型的列
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型参数</param>
        /// <param name="primaryKey">主键ID</param>
        /// <returns>返回由逗号构成的列</returns>
        private static string GetColumnName<T>(T t, string primaryKey)
        {
            if (t == null)
            {
                return string.Empty;
            }            // 链式写法
            return string.Join(",", t.GetType().GetProperties().Where(p => p.Name != primaryKey).Select(p => p.Name).ToArray());
        }
        #endregion


        #region 通过反射获取到T型列对应的值(这里主要是Model类)

        /// <summary>
        /// 通过反射获取到T型列对应的值(这里主要是Model类)
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型参数</param>
        /// <param name="primaryKey">主键ID</param>
        /// <returns></returns>
        private static string GetFieldValue<T>(T t, string primaryKey)
        {
            if (t == null)
            {
                return string.Empty;
            }
            return string.Join(",", t.GetType().GetProperties().Where(p => p.Name != primaryKey).Select(p => p.GetValue(t)).ToArray());

        }

        #endregion

    }
}
