using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;


namespace MyRedisMq.MQ
{
    /// <summary>
    /// redis 消息队列
    /// </summary>
    public class RedisMessageQueue : IDisposable
    {
        public RedisClient redisClient { get; }

        public RedisMessageQueue(string redisHost)
        {
            this.redisClient = new RedisClient(redisHost);
        }

        /// <summary>
        ///  入队
        /// </summary>
        /// <param name="QKey"></param>
        /// <param name="QMessage"></param>
        /// <returns></returns>
        public long EnQueue(string QKey, string QMessage)
        {
            //1 编码字符串
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(QMessage);

            //2 redis消息队列入队
            long count = redisClient.LPush(QKey, bytes);
            return count;
        }

        /// <summary>
        /// 出队
        /// </summary>
        /// <param name="QKey"></param>
        /// <returns></returns>
        public string DeQueue(string QKey)
        {
            //1 编码字符串
            byte[] bytes = redisClient.RPop(QKey);
            string QMessage = null;
            //2 redis消息队列出队
            if (bytes == null)
            {
                Console.WriteLine("队列中的数据为空");
            }
            else
            {
                QMessage = System.Text.Encoding.UTF8.GetString(bytes);
            }
            return QMessage;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
