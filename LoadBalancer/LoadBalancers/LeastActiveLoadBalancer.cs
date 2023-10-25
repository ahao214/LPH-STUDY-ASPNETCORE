using System;
using System.Collections.Generic;

namespace LoadBalancer.LoadBalancers
{
    /// <summary>
    /// 最小活跃数负载均衡算法
    /// </summary>
    public class LeastActiveLoadBalancer
    {
        //1、实例地址集合（集群）
        private List<string> serverAddresss = new List<string>();

        //2、初始化集群实例地址的连接数
        private Dictionary<string, int> serverActives = new Dictionary<string, int>();



        public LeastActiveLoadBalancer()
        {
            serverAddresss.Add("http://localhost5001"); //商品实例1
            serverAddresss.Add("http://localhost5002"); //商品实例2
            serverAddresss.Add("http://localhost5003"); //商品实例3

            //初始化连接数
            serverActives.TryAdd("http://localhost5001", 5);
            serverActives.TryAdd("http://localhost5002", 3);
            serverActives.TryAdd("http://localhost5003", 1);
        }

        /// <summary>
        /// 最小活跃数选择服务地址
        /// </summary>
        /// <returns></returns>
        public string Select()
        {
            //1、获取地址数量
            int serverCount = serverAddresss.Count;
            int leastActive = -1;
            int leastIndex = 0;
            for (int i = 0; i < serverCount; i++)
            {
                //1.1 根据索引找到活跃数
                string serverAddr = serverAddresss[i];

                //1.2 找到活跃数
                int serverActive = serverActives[serverAddr];

                if (leastActive > serverActive)
                {
                    leastActive = serverActive;

                    //赋值索引
                    leastIndex = i;
                }

                //判断是否是第一次进来
                if (leastActive == -1)
                {
                    leastActive = serverActive;
                    leastIndex = i;
                }

                if (leastActive == serverActive)
                {
                    leastIndex = i;
                }
            }

            //2 获取服务器地址进行访问
            string res = serverAddresss[leastIndex];
            Console.WriteLine($"服务地址:{res}");

            //3 更新活跃数
            int currentActive = serverActives[res];
            serverActives[res] += currentActive;


            return res;
        }


    }
}
