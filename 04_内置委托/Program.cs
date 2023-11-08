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


// Func 有返回值
var func = new Func<int, int, int>((a, b) => a + b);
var c = func(1, 2);
Console.WriteLine(c);




