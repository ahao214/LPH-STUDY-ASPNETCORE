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

        public void Show1()
        {
            Console.WriteLine("调用普通方法", this.GetType());
        }

        private void Show2()
        {
            Console.WriteLine("调用私有方法", this.GetType());
        }

        public void Show3<T>()
        {
            Console.WriteLine("调用无参数泛型方法", this.GetType());
        }

        public void Show4<T>(int id, string name)
        {
            Console.WriteLine($"调用有参数构造方法:参数是{id},{name}", this.GetType());
        }






    }
}
