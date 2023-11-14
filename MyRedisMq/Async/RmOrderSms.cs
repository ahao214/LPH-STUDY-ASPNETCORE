using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MyRedisMq.Async
{
    /// <summary>
    /// 订单短信服务
    /// </summary>
    public class RmOrderSms
    {
        /// <summary>
        /// 根据订单发送短信
        /// </summary>
        /// <param name="orderNo"></param>
        public void SendSms(string orderNo)
        {
            //1 调用第三方短信接口
            Thread.Sleep(1000);

            //2 发送短信成功
            Console.WriteLine($"发送短信：{orderNo}成功");
        }

    }

}
