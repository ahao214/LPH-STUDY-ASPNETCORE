using static System.Console;

Title = "委托";

/*
 * 定义委托
 * 委托也是可以定义在类中
 * 委托与类是平级的，都是类型
 */

static double Add(double x, double y)
{
    return x + y;
}

static double Dec(double x, double y)
{
    return x - y;
}

static double Mul(double x, double y)
{
    return x * y;
}

static double Div(double x, double y)
{
    if (y == 0)
        return 0;
    return x / y;
}

static void Test(Cal f)
{
    WriteLine("请输入：X");
    double x = Convert.ToDouble(ReadLine());
    WriteLine("请输入：Y");
    double y = Convert.ToDouble(ReadLine());

    // 委托方法工作，怎么工作由具体委托决定
    double result = f(x, y);
    WriteLine($"X:{x}与Y:{y}委托方法计算结果为：{result}");
}


Cal cal = new Cal(Add);
double result = cal(5, 9);
WriteLine(result);


cal = new Cal(Dec);
result = cal(5, 9);
WriteLine(result);


Cal calTest = Add;
Test(calTest);


public delegate double Cal(double x, double y);




