using static System.Console;

Title = "建造者模式";


/*
 * 设计模式-建造者模式
 * 目的：上家定规范，下家来执行
 */

var builder = new Elephent();
builder.Close();


public abstract class Builder
{
    protected abstract void Step1();
    protected abstract void Step2();
    protected abstract void Step3();

    public void Close()
    {
        Step1();
        Step2();
        Step3();
    }

}


public class Elephent : Builder
{
    protected override void Step1()
    {
        WriteLine("把冰箱门打开");
    }

    protected override void Step2()
    {
        WriteLine("把大象放进去");
    }

    protected override void Step3()
    {
        WriteLine("把冰箱门关上");
    }
}


public class Tiger : Builder
{
    protected override void Step1()
    {
        WriteLine("把冰箱门打开");
    }

    protected override void Step2()
    {
        WriteLine("把老虎放进去");
    }

    protected override void Step3()
    {
        WriteLine("把冰箱门关上");
    }
}