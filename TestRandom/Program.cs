using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            string str = "qwertyuiopasdfghjklzxcvbnm1234567890";
            StringBuilder sb = new StringBuilder();
            // The first method
            for (int i = 0; i < 6; i++)
            {
                sb.Append(str[ran.Next(str.Length)]);
            }

            // The second method
            while (sb.Length < 6)
            {
                sb.Append(str[ran.Next(str.Length)]);
            }

            // The third method
            string strs = new string(Enumerable.Repeat(str, 6).Select(s => s[ran.Next(s.Length)]).ToArray());

            Console.WriteLine(sb.ToString());
            Console.WriteLine(strs);

            Console.ReadKey();

        }
    }
}
