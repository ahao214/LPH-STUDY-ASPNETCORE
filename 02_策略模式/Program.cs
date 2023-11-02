using static System.Console;

Title = "策略模式";

/*
 * 设计模式：策略模式
 * 定义一系列的算法类，将每个算法分别封装起来，让它们可以互相替换
 */


var ef = new EFCoreRepository();
var redis = new RedisRepository();

var appService = new AppSerice(ef);
appService.Create(null);

public interface IReponsitory
{
    void Add(object entity);
}

public class EFCoreRepository : IReponsitory
{
    public void Add(object entity)
    {
        WriteLine("EFCore 仓储");
    }
}

public class RedisRepository : IReponsitory
{
    public void Add(object entity)
    {
        WriteLine("Redis 仓储");
    }
}


class AppSerice
{
    private readonly IReponsitory _reponsitory;
    public AppSerice(IReponsitory reponsitory)
    {
        this ._reponsitory = reponsitory;
    }

    public void Create(object entity)
    {
        _reponsitory.Add(entity);
    }
}



