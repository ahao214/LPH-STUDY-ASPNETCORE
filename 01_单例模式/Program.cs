using static System.Console;

/*
 * 设计模式：单例模式
 * 目的：唯一性 内存资源，GC等
 * 保证整个系统中一个类只有一个对象的实例
 */

Singleton.GetInstance().GetId();
Singleton.GetInstance().GetId();
Singleton.GetInstance().GetId();


Parallel.For(0, 3, index =>
{
    var id = Singleton.GetInstance().GetGuid();
    WriteLine($"第{index}次：{id}");
});

ReadKey();

class Singleton
{
    private Guid _guid;

    private static Singleton _instance;

    private static object _lock = new object();
    private Singleton()
    {
        _guid = Guid.NewGuid();
    }

    public static Singleton GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }

    public void GetId()
    {
        WriteLine(_guid);
    }

    public Guid GetGuid() => _guid;
}
