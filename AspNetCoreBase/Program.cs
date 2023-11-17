using System;

namespace AspNetCoreBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IocShow ioc = new IocShow();
            ioc.Show();

            Console.WriteLine("Hello World!");
        }
    }
}
