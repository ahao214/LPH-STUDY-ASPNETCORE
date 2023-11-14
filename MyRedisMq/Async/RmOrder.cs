using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyRedisMq.Async
{
    /// <summary>
    /// 订单服务
    /// </summary>
    public class RmOrder
    {

        public string CreateOrder()
        {
            // 统计时间
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // 1、订单生成
            string order_no = this.OrderCenrator();

            // 1.1 存储到数据库
            Thread.Sleep(1000);
            Console.WriteLine($"订单：{order_no}保存成功");

            // 2、添加积分
            Console.WriteLine($"---开始调用积分服务---");


            Console.WriteLine($"---积分服务调用完成---");


            // 3、发送短信

            return null;
        }

        /// <summary>
        /// 订单生成器
        /// </summary>
        /// <returns></returns>
        private string OrderCenrator()
        {
            Random ran = new Random();
            return "R" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ran.Next(1000);


        }



    }
}
