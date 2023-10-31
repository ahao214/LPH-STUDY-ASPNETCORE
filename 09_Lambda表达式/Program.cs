using static System.Console;

Title = "Lambda表达式";


// 无参数无返回值
Action action = () => WriteLine("无参数无返回值的Lambda");
action();


// 有参数无返回值Lambda
Action<string> action1 = msg => WriteLine(msg);
action1("有参数无返回值Lambda");


// 有参数有返回值Lambda
Func<int, int> func = (x) =>
{
    return x + 1;
};
WriteLine(func(99));


// Lambda作为参数
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
// 统计数组奇数个数
WriteLine($"arr数组中有{arr.Count(x => x % 2 == 1)}个奇数");



#region Lambda闭包问题

var w = new Test2().CreateWrite();
w("hello 闭包");
w(null);
w(null);
w("你好");
w(null);
w(null);


class Test2
{
    public Action<string?> CreateWrite()
    {
        string msg = "";

        return (string? info) =>
        {
            msg = info ?? msg;
            WriteLine(msg);
        };
    }
}


#endregion



















