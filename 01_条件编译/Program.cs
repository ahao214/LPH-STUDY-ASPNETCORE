#define FREE_VERSION
#define PRO_VERSION
#define 高级版


using System;
using System.Diagnostics;

namespace _01_条件编译
{
    /*
     预处理命令之条件编译
     */
    internal class Program
    {
        static void Main(string[] args)
        {
#if (FREE_VERSION)
            Console.WriteLine("你使用的是免费版");
#elif (PRO_VERSION)
    Console.WriteLine("你使用的是专业版");
#else
Console.WriteLine("你使用的版本未知");
#endif

            //------------------

#if DEBUG
            Console.WriteLine("debug");

#endif
            Console.WriteLine("正常运行");

            //------------------
            Play();

        }

        [Conditional("高级版")]
        static void Play()
        {
            Console.WriteLine("高级玩法！");
        }
    }
}
