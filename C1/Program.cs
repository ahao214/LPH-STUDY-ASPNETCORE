using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace C1
{
    internal class Program
    {
        // 1 委托声明
        public delegate string SayDelegate(string s);

        public delegate void EatAndWatch(string name);

        public static int Calc(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> ca = new Func<int, int, int>(Calc);
            WriteLine(ca.Invoke(1, 1));

            Func<int, int, int> ca1 = Calc;
            WriteLine(ca1(1, 1));

            //2 调用委托
            SayDelegate sd = new SayDelegate(Say);
            Console.WriteLine(sd.Invoke("jack"));

            // 多播委托
            #region 多播委托
            EatAndWatch ewd = Eating;
            ewd += Watching;
            ewd("jack");

            ewd -= Watching;
            ewd("tom");
            #endregion

            Console.ReadLine();
        }

        public static string Say(string s)
        {
            return "hello " + s;
        }


        public static void Eating(string name)
        {
            WriteLine(name + "正在吃饭");
        }

        public static void Watching(string name)
        {
            WriteLine(name + "正在看电视");
        }




    }
}
