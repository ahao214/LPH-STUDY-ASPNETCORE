/*
插件模式开发/模块化框架
反射

1、定义一个标准的基类或接口
2、定义少量的方法、字段...
3、扫描所有程序集 事先筛选掉系统的程序集
 */



using Plugin.Core;
using System.Reflection;

var assemblyFiles= Directory.EnumerateFiles(AppContext.BaseDirectory, "*.dll");

var assemblyList = new List<Assembly>();

foreach (var file in assemblyFiles)
{
    Console.WriteLine("加载程序集：{0}", file);

    // 加载程序集
    var assembly = Assembly.LoadFile(file);
    assemblyList.Add(assembly);
}

var allPublicTypes = assemblyList.SelectMany(m=>m.GetExportedTypes());  

var allPluginTypes = allPublicTypes.Where (type=>type.IsAssignableTo(typeof(IPlugin)));

foreach (var type in allPluginTypes)
{
    var plugin = Activator.CreateInstance(type) as IPlugin;

    plugin?.Execute();
}




