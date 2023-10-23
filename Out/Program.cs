using static System.Console;

Title = "输出参数Out参数";


int a = 1;
WriteLine(a);
int res = Add(out a);
WriteLine($"调用Add方法返回的结果:{res}");
WriteLine($"Add方法中OutValue的值:{a}");


static int Add(out int outValue)
{
    outValue = 5;
    int returnValue = outValue + 1;
    return returnValue;
}