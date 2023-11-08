// 内置委托
// 一种方法的声明和定义 也就是方法的占位符
// Action Func Predicate


//Action 没有返回值
var action = new Action<int, int>((a, b) =>
{
    var c = a + b;
    Console.WriteLine(c);
});

action(1, 2);





