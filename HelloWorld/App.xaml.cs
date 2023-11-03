using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e); // 执行Application父类的OnStartup方法


            Console.WriteLine("1.OnStartup 被执行"); // 加载本地设置参数
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            Console.WriteLine("2.OnActivated 被执行");
        }

        protected override void OnDeactivated(EventArgs e)
        {
            base.OnDeactivated(e);

            Console.WriteLine("3.OnDeactivated 被执行");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);

            Console.WriteLine("4.OnExit 被执行"); // 保存当前缓存数据
        }

    }
}
