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
    public class Program
    {
        // 链接字符串---链接数据库用
        private static readonly string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {
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

            ReadKey();

        }
    }
}
