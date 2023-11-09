using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class MyClass
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }

        public int SumAll(int[]x,int[]y)
        {
            var sum = 0;
            foreach (var x2 in x)
            {
                foreach (var y2 in y)
                {
                    sum += Sum(x2, y2);
                }
            }
            return sum;
        }


    }
}
