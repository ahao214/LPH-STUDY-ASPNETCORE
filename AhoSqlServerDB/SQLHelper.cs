using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Data;

namespace AhoSqlServerDB
{
    /// <summary>
    /// SQL助手
    /// 
    /// 
    /// 封装：抽取变化的 封装不变的
    /// </summary>
    public class SQLHelper
    {
        // 链接字符串---链接数据库用
        private static readonly string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region 增、删、改

        /// <summary>
        /// 增、删、改(insert/delete/update)
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static int GetSingle(string sql)
        {
            SqlConnection conn = new SqlConnection(connString); // 链接数据库
            SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
            try
            {
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                WriteLine("执行GetSingle(string sql)方法出错:" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion


        #region 读取单一结果

        /// <summary>
        /// 读取单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleObject(string sql)
        {
            SqlConnection conn = new SqlConnection(connString); // 链接数据库
            SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令

            try
            {
                conn.Open();
                object obj = cmd.ExecuteScalar();
                return obj;
            }
            catch (Exception ex)
            {
                WriteLine("执行GetSingleObject(string sql)方法出错L:" + ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        #endregion


        #region 读取多个对象

        /// <summary>
        /// 读取多个对象
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString); // 链接数据库
            SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                WriteLine("执行SqlDataReader GetDataReader(string sql)方法出错：" + ex.Message);
                throw ex;
            }
        }


        #endregion



        #region 事务

        /// <summary>
        /// 事务
        /// 显示事务：手动操作的
        /// 隐士事务：平常的一条SQL语句
        /// 
        /// </summary>
        /// <param name="sqlList">SQL语句List</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int UpdateByTransaction(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            // 开启事务
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction(); //开启事务
                int result = 0;
                foreach (string sql in sqlList)
                {
                    cmd.CommandText = sql;
                    result += cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();   //提交事务
                return result;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback(); //回滚事务
                }
                throw new Exception("执行UpdateByTransaction(List<string> sqlList)方法出错:" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null; //清除事务
                }
                conn.Close();
            }
        }

        #endregion










        #region 单一查询结果
        //string sql = "select ClassName from StudentClass where ClassName=N'网络班'";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //object result = cmd.ExecuteScalar();
        //conn.Close();

        //// 展示数据
        //WriteLine($"班级名称是：{result.ToString()}");

        #endregion

        #region 多结果查询

        //string sql = "select Id,ClassName from StudentClass where Id=1";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //StudentClass studentClass = new StudentClass();
        //// 解析数据
        //if (reader.Read())
        //{
        //    studentClass = new StudentClass()
        //    {
        //        Id = Convert.ToInt32(reader["Id"]),
        //        ClassName = reader["ClassName"].ToString()
        //    };
        //}

        //WriteLine($"班级ID：{studentClass.Id},班级名称：{studentClass.ClassName}");

        #endregion

        #region 多条数据

        //string sql = "select Id,ClassName from StudentClass";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //List<StudentClass> lst = new List<StudentClass>();
        //SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //StudentClass studentClass = new StudentClass();
        //// 解析数据
        //while (reader.Read())
        //{
        //    StudentClass stu = new StudentClass()
        //    {
        //        Id = Convert.ToInt32(reader["Id"]),
        //        ClassName = reader["ClassName"].ToString()
        //    };
        //    lst.Add(stu);
        //}

        //foreach (var student in lst)
        //{
        //    WriteLine($"班级ID：{student.Id},班级名称：{student.ClassName}");
        //}

        #endregion

        #region 增加对象

        //string sql = "insert into StudentClass(Id,ClassName) values(10,N'C语言班级')";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //int result = cmd.ExecuteNonQuery();
        //conn.Close();
        //WriteLine("返回结果：" + result);

        #endregion

        #region 删除对象

        //string sql = "delete from StudentClass Where Id= 3";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //int result = cmd.ExecuteNonQuery();
        //conn.Close();
        //WriteLine("返回结果：" + result);

        #endregion

        #region 修改对象

        //string sql = "update StudentClass set ClassName=N'JS班级' where Id=4";

        //SqlConnection conn = new SqlConnection(connString); // 链接数据库
        //SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
        //conn.Open();
        //int result = cmd.ExecuteNonQuery();
        //conn.Close();
        //WriteLine("返回结果：" + result);

        #endregion
    }
}
