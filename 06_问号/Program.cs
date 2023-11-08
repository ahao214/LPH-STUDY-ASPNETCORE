using static System.Console;

// 变成可为空的类型
int? x = null;
WriteLine(x);

// ? 表达式

// 1.三元运算符

var result = true ? 1 : 2;

// not null ?? is null

string name = default;

// name 是null走右边 不是null的时候走左边
var str = name ?? "abc";

public class C1
{
    public C1(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }
    public string Name { get; }
}


// 可空操作符 ?.

