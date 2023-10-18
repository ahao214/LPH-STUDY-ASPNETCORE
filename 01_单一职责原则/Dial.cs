using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_单一职责原则
{
    public class Dial : IDial
    {
        public void DialNumber(string phoneNumber)
        {
            Console.WriteLine("给" + phoneNumber + "打电话");
        }
    }
}
