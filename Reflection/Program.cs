using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;



namespace Reflection
{
    /// <summary>
    /// 反射：就是操作dll文件的一个类库
    /// 怎么使用：1、查找dll文件 2、通过Reflection反射类库里的各种方法来操作dll文件
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 加载dll文件

            // 方式一:这个DLL文件要在启动项目下
            Assembly assembly1 = Assembly.Load("SqlServerDB");

            // 方式二：完整路径
            Assembly assembly2 = Assembly.LoadFile(@"F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\SqlServerDB\bin\Debug\SqlServerDB.dll");

            // 方式三：完整路径
            Assembly assembly3 = Assembly.LoadFrom(@"F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\SqlServerDB\bin\Debug\SqlServerDB.dll");

            Assembly assembly4 = Assembly.LoadFrom(@"SqlServerDB.dll");

        }
    }
}
