using System;


namespace LoadBalancer.LoadBalancers
{
    /// <summary>
    /// 最小活跃数负载均衡算法
    /// </summary>
    public class LeastActiveLoadBalancer
    {
        //1、实例地址集合（集群）
        private List<string> serverAddresss = new List<string>();

        public LeastActiveLoadBalancer()
        {
            serverAddresss.Add("http://localhost5001");
            serverAddresss.Add("http://localhost5002");
            serverAddresss.Add("http://localhost5003");
        }

        /// <summary>
        /// 最小活跃数选择服务地址
        /// </summary>
        /// <returns></returns>
        public string Select()
        {
            return null;
        }


    }
}
