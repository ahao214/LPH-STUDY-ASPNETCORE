using static System.Console;

Title = "抽象类";

/*
 * 作用：只能作用为其他类的基类存在
 * 1、不能创建抽象类的实例
 * 2、使用abstract修饰符声明
 */


abstract class ABClass
{
    abstract public void Test1();
    public void Test2()
    {
        WriteLine("我是抽象类的实例方法");
    }

    abstract public int Name { get; set; }
}