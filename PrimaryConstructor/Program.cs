// 主要构造函数


class MyClass(string? name = default)
{
    public MyClass(string? name, int? Age = default) : this(name)
    {
        Age = Age;
    }
    public string? Name => name;
    public int? Age { get; }
}