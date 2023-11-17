﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using SqlServerDB;

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
            //[1] 加载dll文件

            // 方式一:这个DLL文件要在启动项目下
            //Assembly assembly1 = Assembly.Load("SqlServerDB");

            // 方式二：完整路径
            //Assembly assembly2 = Assembly.LoadFile(@"F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\SqlServerDB\bin\Debug\SqlServerDB.dll");

            // 方式三：完整路径
            //Assembly assembly3 = Assembly.LoadFrom(@"F:\MyProgramm\CShape\LPH-STUDY-ASPNETCORE\SqlServerDB\bin\Debug\SqlServerDB.dll");

            Assembly assembly4 = Assembly.LoadFrom(@"SqlServerDB.dll");


            //[2] 获取指定类型
            Type type = assembly4.GetType("SqlServerDB.ReflectionTest");

            // 获取所有类型
            foreach (var item in assembly4.GetTypes())
            {
                Console.WriteLine(item.Name);
            }

            // 获取类型里面的所有的构造方法
            foreach (var item in  type.GetConstructors())
            {
                Console.WriteLine($"构造方法：{item.Name}"); 
            }


            //[3] 实例化
            //ReflectionTest refTest = new ReflectionTest();  //这种实例化是知道具体类型，是静态实例化

            // 动态实例化--调用我们的构造方法
            //object obj1 = Activator.CreateInstance(type);

            // 动态实例化--调用我们的有参数的构造方法
            //object obj2 = Activator.CreateInstance(type, new object[] { "Block编程" });


            // 调用私有构造函数
            //object obj3 = Activator.CreateInstance(type, true);




            Console.ReadKey();
        }
    }
}
