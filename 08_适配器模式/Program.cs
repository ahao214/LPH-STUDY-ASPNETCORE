using static System.Console;

/*
设计模式：适配器模式
将一个类的接口转换成客户希望的另一个接口
使得原本由于接口不兼容而不能一起工作的那些类可以一起工作

*/

IExpectedInterface client = new ExistObject();

WriteLine(client.Name);

Adapter adapter = new Adapter();
client = adapter;
WriteLine(client.Name);



interface IExpectedInterface
{
    public string Name { get; set; }
}

class ExistObject : IExpectedInterface
{
    public string Name { get; set; } = "已经存在";
}


class YourClass
{
    public DateOnly Birthday { get; set; }
}


/// <summary>
/// 适配器
/// </summary>
class Adapter : YourClass, IExpectedInterface
{
    public Adapter()
    {
        Name = base.Birthday.ToString();
    }
    public string Name { get; set; }
}