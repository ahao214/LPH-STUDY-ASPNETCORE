using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_单一职责原则
{
    public class SendMessageClass : ISendMessage
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("发送" + message);
        }
    }
}
