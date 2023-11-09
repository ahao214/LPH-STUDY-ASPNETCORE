using Plugin.Core;
using static System.Console;


namespace AppPlugin
{
    public class Plugin2 : IPlugin
    {
        public void Execute()
        {
            WriteLine("插件2在执行");            
        }
    }
}