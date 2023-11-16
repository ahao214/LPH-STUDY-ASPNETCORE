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
        static void Main(string[] args)
        {
            //string sql = "insert into StudentClass(ClassName) values(N'JS高级')";
            //int result = SQLHelper.GetSingle(sql);
            //if (result > 0)
            //{
            //    WriteLine("插入成功");
            //}
            //else
            //{
            //    WriteLine("插入失败");
            //}


            //string sql = "select id,classname from studentclass where id=10000";
            //object stuObject = SQLHelper.GetSingleObject(sql);
            //int classId = (int)stuObject;
            //WriteLine($"班级ID:{classId}");

            string sql = "select id,classname from studentclass";
            SqlDataReader reader = SQLHelper.GetDataReader(sql);
            List<StudentClass> stuList = new List<StudentClass>();

            while (reader.Read())
            {
                StudentClass stu = new StudentClass();
                stu.Id = Convert.ToInt32(reader["id"]);
                stu.ClassName = reader["ClassName"].ToString();
                stuList.Add(stu);
            }

            foreach (var item in stuList)
            {
                WriteLine($"班级ID:{item.Id},班级名称：{item.ClassName}");
            }



            ReadKey();

        }
    }
}
