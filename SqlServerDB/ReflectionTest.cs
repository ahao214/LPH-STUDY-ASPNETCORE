using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerDB
{
    /// <summary>
    /// 反射测试类
    /// </summary>
    public class ReflectionTest
    {
        private ReflectionTest()
        {
            Console.WriteLine("这是私有的无参数构造方法");
        }

        //public ReflectionTest()
        //{
        //    Console.WriteLine("这是无参数构造方法");
        //}

        //public ReflectionTest(string name)
        //{
        //    Console.WriteLine($"这是有参数构造方法：{name}");
        //}

    }
}
