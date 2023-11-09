using static System.Console;


int pageIndex = 1;
int pageSize = 10;
List<string> dataSource = new List<string>();
do
{
    Write("请输入页码：");
    pageIndex = int.Parse(ReadLine());

    if (pageIndex < 0)
    {
        break;
    }

    var pagedSource = dataSource.Skip((pageIndex - 1) * pageSize).Take(pageSize);
    WriteLine($"第{pageIndex}页数据：{string.Join(",", pagedSource)}");
} while (pageIndex > 0);

WriteLine("退出");

