/*
插件模式开发/模块化框架
反射

1、定义一个标准的基类或接口
2、定义少量的方法、字段...
3、扫描所有程序集 事先筛选掉系统的程序集
 */



Directory.EnumerateFiles(AppContext.BaseDirectory, "*.dll");
