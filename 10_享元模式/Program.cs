using static System.Console;

/*
设计模式：享元模式
目的：缓存
*/

CacheManager cacheManager = new();
var value = cacheManager.GetOrCreate<Operation1>("key", () => new() { Name = "Init" });

WriteLine(value.Name);
var value1 = cacheManager.GetOrCreate<Operation1>("key");
WriteLine(value1.Name);

interface IOperation
{
    string Name { get; set; }
}

class Operation1 : IOperation
{
    public string Name { get; set; }
}

class CacheManager
{
    private static Dictionary<string, IOperation> _operation = new();

    public IOperation GetOrCreate<T>(string key, Func<T>? func = default) where T:IOperation,new()
    {
        if (!_operation.ContainsKey(key))
        {
            _operation.Add(key, func is null ? new T(): func());
        }
        return _operation[key];
    }
}

