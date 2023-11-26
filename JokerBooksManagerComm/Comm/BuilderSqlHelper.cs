using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokerBooksManagerComm.Comm
{
    /// <summary>
    /// 通过反射创建SQL语句
    /// </summary>
    public class BuilderSqlHelper
    {
        #region 获取SQL的插入语句
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
            sb.Append($" VALUES( {fieldValues} )");

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
            return string.Join(",", t.GetType().GetProperties().Where(p => p.Name != primaryKey).Select(p => string.Format("'{0}'", p.GetValue(t))).ToArray());

        }

        #endregion


        #region 获取SQL的查询语句

        /// <summary>
        /// 获取SQL的查询语句
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型变量</param>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键ID</param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static string SelectSql<T>(T t, string tableName, string primaryKey, Dictionary<string, object> dict) where T : class
        {
            if (t is null || string.IsNullOrEmpty(tableName))
                return string.Empty;
            // 获取字段名称
            string colNames = GetColumnName<T>(t, primaryKey);
            StringBuilder sb = new StringBuilder();
            sb.Append($"SELECT {colNames} FROM {tableName} WHERE 1 = 1");
            foreach (KeyValuePair<string, object> kv in dict)
            {
                string sType = kv.Value.GetType().ToString().ToLower();
                // 证明是数字的值
                bool bNum = sType.Contains("int") || sType.Contains("float") || sType.Contains("double") || sType.Contains("decimal");

                if (bNum)
                {
                    sb.Append($" AND {kv.Key} = {kv.Value}");
                }
                else
                {
                    sb.Append($" AND {kv.Key} = '{kv.Value}'");
                }
            }
            sb.Append($" ORDER BY {primaryKey} ASC");

            return sb.ToString();
        }


        #endregion

        #region 获取SQL的查询语句

        /// <summary>
        /// 获取SQL的查询语句
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型变量</param>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键ID</param>        
        /// <returns></returns>
        public static string SelectSql<T>(T t, string tableName, string primaryKey) where T : class
        {
            if (t is null || string.IsNullOrEmpty(tableName))
                return string.Empty;
            Type type = t.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            string colNames = string.Join(",", propertyInfos.Select(p => p.Name));

            StringBuilder sb = new StringBuilder();
            sb.Append($"SELECT {colNames} FROM {tableName} ");
            sb.Append($" ORDER BY {primaryKey} ASC");

            return sb.ToString();
        }


        #endregion


        #region 获取SQL的更新语句

        /// <summary>
        /// 获取SQL的更新语句
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型变量</param>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键ID</param>
        /// <param name="keyId">查询的条件</param>
        /// <returns></returns>
        public static string UpdateSql<T>(T t, string tableName, string primaryKey, int keyId) where T : class
        {
            if (t is null || string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(primaryKey))
                return string.Empty;

            // 获取当前类型
            Type type = t.GetType();
            // 获取到属性数组
            PropertyInfo[] properties = type.GetProperties();
            string sColVal = "";
            foreach (PropertyInfo pi in properties)
            {
                if (pi.Name != primaryKey)
                {
                    sColVal += (string.IsNullOrEmpty(sColVal) ? "" : ",") + string.Format("{0}='{1}'", pi.Name, pi.GetValue(t));
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append($"UPDATE {tableName} SET ");
            sb.Append(sColVal);
            sb.Append($" WHERE {primaryKey} = {keyId}");

            return sb.ToString();

        }


        #endregion


        #region 获取SQL的删除语句(根据主键来删除)

        /// <summary>
        /// 获取SQL的删除语句(根据主键来删除)
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="t">泛型变量</param>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键ID</param>
        /// <param name="keyId">查询的条件</param>
        /// <returns></returns>
        public static string DeleteSql<T>(T t, string tableName, string primaryKey) where T : class
        {
            if (t is null || string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(primaryKey))
                return string.Empty;

            Type type = typeof(T);

            StringBuilder sb = new StringBuilder();
            sb.Append($"DELETE FROM {tableName}");
            sb.Append($" WHERE {primaryKey} = {type.GetProperty(primaryKey).GetValue(t)}");

            return sb.ToString();

        }


        #endregion
    }
}
