using static System.Console;

Title = "匿名方法";

static int Add(int a, int b)
{
    return a + b;
}


Calculate cals = delegate (int a, int b)
{
    return a + b;
};

var result = cals(1, 2);
WriteLine(result);


// 匿名方法
Cal cal = delegate (int a, int b)
{
    return a + b;
};

// Lambda
Cal cal2 = (int a, int b) =>{return a+ b;};

// Lambda简化
Cal cal3 = (a, b) => a + b;


public delegate int Calculate(int a, int b);


public delegate int Cal(int a, int b);