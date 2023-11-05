using static System.Console;

Title = "多播委托";



Calculate cal = Add;
cal += Sub; // 添加方法
cal(5, 2);  // 委托方法调用



static void Add(int a, int b)
{
    WriteLine(a + b);
}

static void Sub(int a, int b)
{
    WriteLine(a - b);
}



delegate void Calculate(int a, int b);

