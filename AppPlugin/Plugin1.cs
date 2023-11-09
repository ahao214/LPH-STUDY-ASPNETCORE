using Plugin.Core;
using static System.Console;


namespace AppPlugin
{
    public class Plugin1 : IPlugin
    {
        public void Execute()
        {
            WriteLine("插件1在执行");            
        }
    }
}