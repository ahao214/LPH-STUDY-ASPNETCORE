// 委托
// 一种方法的声明和定义 也就是方法的占位符

// 参数 属性


var cal = new Calculator();
var result =cal.DoAdd(MakePlus);

cal.DoAdd((x, y) =>
{
    return x + y;
});



static int MakePlus(int a, int b)
{
    return a + b;
}


int Add(int a,int b)
{
    return a + b;
}


class Calculator
{
    public delegate int Add(int a, int b);

    public int DoAdd(Add action)
    {
        return action(1, 2);

    }

    public int AddMethod(int a, int b)
    {
        return a + b;
    }
}
