using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {


        }


        /// <summary>
        /// 添加数据
        /// </summary>
        static void Add()
        {
            using (var db = new Entities())
            {
                Student stu = new Student
                {
                    Name = "Castle编程",
                    Address = "SH",
                    Age = 33,
                    Phone = "110"
                };
                db.Student.Add(stu);
                db.SaveChanges();   //执行到数据库
            }

        }

    }
}
