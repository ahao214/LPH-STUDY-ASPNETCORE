using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace E2
{
    internal class Program
    {
        // 筛选符合价格的所有商品
        public static IEnumerable<Goods> GetList(List<Goods> lst, decimal price)
        {
            List<Goods> list = new List<Goods>();
            foreach (var item in lst)
            {
                if (item.Price == price)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        // 使用yield
        public static IEnumerable<Goods> GetList1(List<Goods> lst, decimal price)
        {
            foreach (var item in lst)
            {
                if (item.Price == price)
                {
                    yield return item;
                }
            }
        }


        SayDele s3 = (x) => { WriteLine("你好" + x); };

        Action<string> action = (x) =>
        {
            WriteLine("你好:" + x);
        };

        Action<string> action1 = new Action<string>(
            (x) =>
            {
                WriteLine("你好：" + x);
            });




        public delegate void SayDele(string name);
        public static void SayHello(string name)
        {
            WriteLine("你好:" + name);
        }


        static void Main(string[] args)
        {
            List<Goods> list = new List<Goods>()
            {
                new Goods (){Id =1,Name ="苹果",Price=5},
                new Goods (){Id =2,Name ="苹果",Price=4},
                new Goods (){Id =3,Name ="苹果",Price=5},
                new Goods (){Id =4,Name ="苹果",Price=33},
                new Goods (){Id =5,Name ="苹果",Price=5},
                new Goods (){Id =6,Name ="苹果",Price=333}
            };
            GetList(list, 5);

            #region LINQ

            // 查询价格等于5的商品信息
            var res1 = from a in list
                         where a.Price == 5
                         select a;

            // 方法语法
            string[] names = { "jack", "tom", "harry", "mary", "jay" };
            var query = names.Where(n => n.Contains("q"))
                .OrderBy(n => n.Length);



            #endregion


            ReadKey();
        }
    }
}
