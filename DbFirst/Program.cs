using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace DbFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Add();

            ReadKey();
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
                    Name = "Castle编程2",
                    Address = "SH",
                    Age = 33,
                    Phone = "110"
                };
                // 方式一
                //db.Student.Add(stu);

                // 方式二
                db.Entry(stu).State = EntityState.Added;

                int result = db.SaveChanges();   //执行到数据库
                if (result > 0)
                {
                    Console.WriteLine("添加数据成功");
                }
                else
                {
                    Console.WriteLine("添加数据失败");
                }
            }

        }


        #region 批处理

        static void AddBatch()
        {
            using (var db = new Entities())
            {
                for (int i = 0; i < 5; i++)
                {
                    Student stu = new Student
                    {
                        Name = "Castle编程2" + i,
                        Address = "SH" + i,
                        Age = 20 + i,
                        Phone = "110"
                    };
                    db.Student.Add(stu);
                }
                db.SaveChanges();
            }
        }

        #endregion


    }
}
