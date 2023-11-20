using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }


        private void CfkJob()
        {
            for(int i =1;i<10;i++)
            {
                for(int j = 1;j<=i;j++)
                {
                    int m = i * j;
                    Console.Write($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
