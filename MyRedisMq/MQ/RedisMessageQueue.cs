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
        /// 出队(非阻塞)
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

        /// <summary>
        /// 出队(阻塞)
        /// </summary>
        /// <param name="QKey"></param>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public string BDeQueue(string QKey, TimeSpan? timeSpan)
        {
            //1 redis 消息出队
            string QMessage = redisClient.BlockingPopItemFromList(QKey, timeSpan);

            return QMessage;
        }

        /// <summary>
        /// 获取队列数量
        /// </summary>
        /// <param name="QKey"></param>
        /// <returns></returns>
        public long GetQueueCount(string QKey)
        {
            return redisClient.GetListCount(QKey);
        }

        public void Dispose()
        {
            //1 关闭redis
            redisClient.Dispose();
        }
    }
}
