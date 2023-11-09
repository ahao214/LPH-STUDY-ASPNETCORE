using static System.Console;


int pageIndex = 1;
int pageSize = 10;
var dataSource = Enumerable.Range(1, 100);
do
{
    Write("请输入页码：");
    pageIndex = int.Parse(ReadLine());

    if (pageIndex < 0)
    {
        break;
    }

    var pagedSource = dataSource.Skip((pageIndex - 1) * pageSize).Take(pageSize);

    var totalCount = dataSource.Count();
    var totalPages = totalCount % pageSize == 0 ? totalCount / pageSize : totalCount / pageSize + 1;

    WriteLine($"第{pageIndex}页数据：{string.Join(",", pagedSource)}");

} while (pageIndex > 0);

WriteLine("退出");

