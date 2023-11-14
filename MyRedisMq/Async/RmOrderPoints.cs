using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyRedisMq.Async
{
    /// <summary>
    /// 订单积分服务
    /// </summary>
    public class RmOrderPoints
    {
        /// <summary>
        /// 根据订单增加积分
        /// </summary>
        /// <param name="orderNo"></param>
        public void AddPoints(string orderNo)
        {
            //1 调用积分服务
            Thread.Sleep(1000);

            //2 发送积分成功
            Console.WriteLine($"增加积分：orderNo:{orderNo}成功");
        }

    }
}
