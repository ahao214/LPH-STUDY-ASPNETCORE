using static System.Console;
using System.Threading;

// 异步


Thread.Sleep(5000);
WriteLine("beginning");
await GetData();
WriteLine("end");

ReadKey();

static Task GetData()
{
    return Task.Run(() =>
    {
        Thread.Sleep(2000);
        WriteLine("获取到数据");
    });
}