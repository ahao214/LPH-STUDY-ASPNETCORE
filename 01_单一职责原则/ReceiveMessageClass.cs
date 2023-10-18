using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_单一职责原则
{
    public class ReceiveMessageClass : IReceiveMessage
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("接收" + message);
        }
    }
}
