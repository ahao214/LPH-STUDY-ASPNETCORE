using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace AhoSqlServerDB
{
    public class Program
    {
        // 链接字符串---链接数据库用
        private static readonly string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StudentManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {
            // 准备好SQL语句
            string sql = "select ClassName from StudentClass where ClassName=N'网络班'";

            SqlConnection conn = new SqlConnection(connString); // 链接数据库
            SqlCommand cmd = new SqlCommand(sql, conn); //发送SQL命令
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            // 展示数据
            WriteLine($"班级名称是：{result.ToString()}");

            ReadKey();

        }
    }
}
