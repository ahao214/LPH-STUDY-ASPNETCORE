using static System.Console;

Title = "调用基类和自己的构造方法";





//base 关键字作用一

class Student
{
    public void Speak()
    {
        WriteLine("说中文");
    }
}


class StuJack : Student
{
    public StuJack()
    {
        // 访问基类成员
        base.Speak();
    }

    public void Speak()
    {
        WriteLine("说英文");
    }
}

