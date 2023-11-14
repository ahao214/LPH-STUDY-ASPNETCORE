using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyRedisMq.MQ;


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
            string order_no = this.OrderGenrator();

            // 1.1 存储到数据库
            Thread.Sleep(1000);
            Console.WriteLine($"订单：{order_no}保存成功");

            // 2、添加积分
            //Console.WriteLine($"---开始调用积分服务---");
            //RmOrderPoints rmOrderPoints = new RmOrderPoints();
            //rmOrderPoints.AddPoints(order_no);

            //Console.WriteLine($"---积分服务调用完成---");


            //// 3、发送短信
            //Console.WriteLine($"---开始调用发送短信服务---");
            //RmOrderSms rmOrderSms = new RmOrderSms();
            //rmOrderSms.SendSms(order_no);

            //Console.WriteLine($"---发送短信服务调用完成---");

            #region redis优化



            #endregion


            stopWatch.Stop();
            Console.WriteLine($"订单完成耗时：{stopWatch.ElapsedMilliseconds} ms");

            return order_no;
        }

        /// <summary>
        /// 订单生成器
        /// </summary>
        /// <returns></returns>
        private string OrderGenrator()
        {
            Random ran = new Random();
            return "R" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ran.Next(1000);


        }



    }
}
