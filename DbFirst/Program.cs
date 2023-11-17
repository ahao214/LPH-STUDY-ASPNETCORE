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

        #region 添加数据

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

        #endregion

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

        #region 查询

        static void Query()
        {

            using (var db = new Entities())
            {
                // 根据ID查询
                //var stu1 = db.Student.Find(1);
                //WriteLine(stu1.Name);


                // 根据条件查询
                var query = db.Student.Where(s => s.Id > 1);
                foreach (var item in query)
                {
                    WriteLine(item.Name);
                }

                // 查询所有
                var lstStudent = db.Student.ToList();
                foreach (var item in lstStudent)
                {
                    WriteLine($"StudentID is ：{item.Id},Student's name is :{item.Name}");
                }

                // 延迟查询


                // 分页查询
            }


        }

        #endregion

    }
}
