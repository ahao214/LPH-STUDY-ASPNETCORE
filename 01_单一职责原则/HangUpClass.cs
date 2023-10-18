using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_单一职责原则
{
    public class HangUpClass : IHangUp
    {
        public void HangUp(string phoneNumber)
        {
            Console.WriteLine("挂断" + phoneNumber + "电话");
        }
    }
}
