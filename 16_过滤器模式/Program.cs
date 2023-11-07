using static System.Console;

// 设计模式：过滤器模式

var list = Enumerable.Range(1, 1000);

FilterA filterA = new();
FilterB filterB = new();

list = filterA.Filter(list);
list = filterB.Filter(list);

foreach (var item in list)
{
    WriteLine(item);
}

interface IFilter
{
    IEnumerable<int> Filter(IEnumerable<int> list);
}


class FilterA : IFilter
{
    public IEnumerable<int> Filter(IEnumerable<int> list)
    {
        if (list.Sum() > 100)
        {
            WriteLine("超过了10");
            list = list.Skip(10).ToList();
        }
        return list;
    }
}

class FilterB : IFilter
{
    public IEnumerable<int> Filter(IEnumerable<int> list)
    {
        if (list.Count() > 40)
        {
            list = list.Take(10).ToList();
        }
        return list;
    }
}