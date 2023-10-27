using static System.Console;

Title = "调用基类和自己的构造方法";





//base 关键字作用一
//访问基类成员

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




//base 关键字作用二
//调用基类构造方法
class Teacher
{
    public Teacher()
    {

    }

    public Teacher(string info)
    {
        WriteLine(info);
    }
}


class TeacherTom : Teacher
{
    // 调用基类构造方法
    public TeacherTom() : base("Tom老师")
    {

    }
}
