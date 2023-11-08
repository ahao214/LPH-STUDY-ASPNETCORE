using static System.Console;

// using 关键字的用法


// 1.引用命名空间

// 2.自动释放资源

// 3.给类一个别名

using MyClass1 = Name1.MyClass;
using MyClass2 = Name2.MyClass;

var myClass1 = new MyClass1();
var myClass2 = new MyClass2();  

namespace Name1
{
    class MyClass { }
}

namespace Name2
{
    class MyClass { }
}