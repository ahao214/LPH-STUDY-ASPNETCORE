using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLambda
{
    /// <summary>
    /// 委托
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 委托初始化
            HelloDelegate helloDelegate = new HelloDelegate(Hello);
            // 调用
            helloDelegate.Invoke("");

            AddDele addDele = new AddDele(Add);
            int sum = addDele.Invoke(1, 2);
            Console.WriteLine(sum);

            #region Lambda

            Action<string> action1 = new Action<string>(delegate (string msg)
            {
                Console.WriteLine(msg);
            });

            action1("你好我是泛型委托Action 使用了匿名方法");


            Action<string> action2 = new Action<string>((string msg) =>
            {
                Console.WriteLine(msg);
            });
            action2("你好我是泛型委托Action 使用了匿名方法");

            // 一个参数 一个语句
            Action<string> action3 = new Action<string>(msg => Console.WriteLine(msg));


            #endregion


            Console.ReadKey();
        }

        public static void Hello(string msg)
        {
            Console.WriteLine("我是委托");
        }


        public static int Add(int a, int b)
        {
            return a + b;
        }

    }

    //定义委托
    delegate void HelloDelegate(string msg);

    delegate int AddDele(int a, int b);

    class MyClass
    {
        public void Hello(string msg)
        {
            Console.WriteLine("我是委托");
        }
    }
}
