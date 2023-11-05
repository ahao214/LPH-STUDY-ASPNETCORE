using static System.Console;

Title = "多播委托";

/*
多播委托——注意事项
1、多播委托执行方法的顺序不确定
2、如果方法有返回值，返回最后一个方法的值
*/

Calculate cal = Add;
cal += Sub; // 添加方法
cal(5, 2);  // 委托方法调用

WriteLine("--移除方法后--");
cal -= Sub;
cal(3, 4);



static void Add(int a, int b)
{
    WriteLine(a + b);
}

static void Sub(int a, int b)
{
    WriteLine(a - b);
}



delegate void Calculate(int a, int b);

