using MyRedisMq.Async;
using System;

namespace MyRedisMq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redis专题一(消息队列)!");

            #region 异步处理

            RmOrder order = new RmOrder();
            order.CreateOrder();


            #endregion


            Console.ReadKey();
        }
    }
}
