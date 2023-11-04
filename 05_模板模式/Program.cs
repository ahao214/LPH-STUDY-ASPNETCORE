using static System.Console;

/*
 * 设计模式：模板模式
 * 目的：只留出必要的部分让子类自定义
 */


var tem = new MyTemplate2();
tem.GetResult();


abstract class TemplateBase
{
    void Step1()
    {
        WriteLine("步骤1");
    }

    void Step2()
    {
        WriteLine("步骤2");
    }

    protected abstract void Step3();

    protected virtual void Step4()
    {
        WriteLine("步骤4");
    }

    public void GetResult()
    {
        Step1();
        Step2();
        Step3();
        Step4();
    }
}


class MyTemplate : TemplateBase
{
    protected override void Step3()
    {
        WriteLine("子类的步骤");
    }
}


class MyTemplate2 : TemplateBase
{
    protected override void Step3()
    {
        WriteLine("子类的步骤");
    }

    protected override void Step4()
    {
        WriteLine("心情不好,我想重写");
    }
}