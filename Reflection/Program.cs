using System;
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
            foreach (var ctor in type.GetConstructors())
            {
                Console.WriteLine($"构造方法：{ctor.Name}");
                foreach (var param in ctor.GetParameters())
                {
                    Console.WriteLine($"构造方法的参数：{param.ParameterType}");
                }
            }


            //[3] 实例化
            //ReflectionTest refTest = new ReflectionTest();  //这种实例化是知道具体类型，是静态实例化

            // 动态实例化--调用我们的构造方法
            //object obj1 = Activator.CreateInstance(type);

            // 动态实例化--调用我们的有参数的构造方法
            //object obj2 = Activator.CreateInstance(type, new object[] { "Block编程" });


            // 调用私有构造函数
            object obj3 = Activator.CreateInstance(type, true);

            // 调用普通方法
            ReflectionTest reflectionTest = obj3 as ReflectionTest;// as 转换的好处，它不报错，类型不对的话就返回null
            reflectionTest.Show1();

            // 调用私有方法
            var method = type.GetMethod("Show2",BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(obj3, new object[] { });

            Console.WriteLine("--------泛型方法调用--------");

            // 无参数
            var method3 = type.GetMethod("Show3");// 查找指定方法
            var genMethod = method3.MakeGenericMethod(new Type[] { typeof(int) });  //指定泛型参数类型T
            genMethod.Invoke(obj3, new object[] { });

            // 有参数
            var method4 = type.GetMethod("Show4");// 查找指定方法
            var genMethod4 = method4.MakeGenericMethod(new Type[] { typeof(string) });  //指定泛型参数类型T
            genMethod.Invoke(obj3, new object[] {123,"block编程" });

            Console.ReadKey();
        }
    }
}
