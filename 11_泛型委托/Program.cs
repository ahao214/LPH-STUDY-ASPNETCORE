using static System.Console;

Title = "泛型委托";


/*
 Action 无返回值的委托
 Func   有返回值的委托
 */


Action<string> action = SayHi;
action("hello");

Func<double, double, double> func = Add;
double result = func(1.1, 2.2);
WriteLine(result);




static void SayHi(string msg)
{
    WriteLine(msg);
}


static double Add(double x, double y)
{
    return x + y;
}

static double Mul(double x, double y)
{
    return x * y;
}







