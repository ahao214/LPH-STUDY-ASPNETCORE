using static System.Console;

Title = "委托";

/*
 * 定义委托
 * 委托也是可以定义在类中
 * 委托与类是平级的，都是类型
 * 
 * 
 */

static double Add(double x, double y)
{
    return x + y;
}

static double Dec(double x, double y)
{
    return x - y;
}


Cal cal = new Cal(Add);
double result = cal(5, 9);
WriteLine(result);


cal = new Cal(Dec);
result = cal(5, 9);
WriteLine(result);



public delegate double Cal(double x, double y);




