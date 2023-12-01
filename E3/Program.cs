using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E3.Model;
using static System.Console;


namespace E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (FreshLiveDB db = new FreshLiveDB())
            {
                // 增加
                //ProductClass pc = new ProductClass()
                //{
                //    Name = "C#班"
                //};

                //db.ProductClass.Add(pc);
                //db.SaveChanges();


                // 删除
                //var delPc = db.ProductClass.Where(a => a.Id == 6).FirstOrDefault();
                //db.ProductClass.Remove(delPc);
                //if (db.SaveChanges() > 0)
                //{
                //    WriteLine("Delete Successful");
                //}
                //else
                //{
                //    WriteLine("Delete fail");
                //}

                // 修改
                //var upd = db.ProductClass.Where(a => a.Id == 7).FirstOrDefault();

                //upd.Name = "饮料";
                //upd.Id = 7;
                //if (db.SaveChanges() > 0)
                //{
                //    WriteLine("修改成功");
                //}
                //else
                //{
                //    WriteLine("修改失败");
                //}


                // 查询
                var result = db.ProductClass.ToList();
                foreach (var item in result)
                {
                    WriteLine(item.Id + " " + item.Name);
                }


            }


            using (FreshLiveDB db = new FreshLiveDB())
            {
                // 建表
                string sql = "drop table JW3";
                if (db.Database.ExecuteSqlCommand(sql) ==-1)
                {
                    WriteLine("操作成功");
                }
                else
                {
                    WriteLine("操作失败");
                }



            }

            ReadLine();

        }
    }
}
