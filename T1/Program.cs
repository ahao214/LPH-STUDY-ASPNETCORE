using System;
using System.Threading;
using System.Threading.Tasks;

namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoilWater();
            Clean();
            Pao();

        }


        static void BoilWater()
        {
            Console.WriteLine("烧开水");
            Thread.Sleep(5000);
        }

        // 异步方法
        async static void CleanAsync()
        {
            // 新开线程
            string result = await CleanA();
            Console.WriteLine(result);
        }

        // await调用的方法返回值必须为Task<T>
        static Task<string> CleanA()
        {
            
            return Task.Run<string>(() =>
            {
                // 匿名函数方法体 实际新开线程的执行代码
                Thread.Sleep(5000);
                return "清洗茶具";
            });
        }


        static void Clean()
        {
            Console.WriteLine("清洗茶具");
            Thread.Sleep(5000);
        }

        static void Pao()
        {
            Console.WriteLine("泡茶");
            Thread.Sleep(5000);
        }


    }
}
