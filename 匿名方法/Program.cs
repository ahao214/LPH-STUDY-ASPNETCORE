using static System.Console;

Title = "匿名方法";



Calculate cal = delegate (int a, int b)
{
    return a + b;
};

var result = cal(1, 2);
WriteLine(result);

public delegate int Calculate(int a, int b);
