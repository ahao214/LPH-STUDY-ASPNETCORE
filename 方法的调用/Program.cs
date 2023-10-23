using static System.Console;

Title = "方法的调用";


WriteLine("开始调用方法");
MethodA(3, 4);
WriteLine("结束方法调用");



static void MethodA(int a, int b)
{
    WriteLine($"MehtoA:a={a},b={b}");
    MethodB(1, 2);
    WriteLine("退出方法MethodA");
}


static void MethodB(int a, int b)
{
    WriteLine($"MehtoB:a={a},b={b}");
    WriteLine("退出方法MethodB");
}