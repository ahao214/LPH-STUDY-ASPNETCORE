using static System.Console;

Title = "静态类";


/*
作用：用于存放不受实例数据影响数据和函数
1、使用static修饰符声明
2、所有成员必须是静态的
3、只能有一个静态构造函数
4、隐式密封的，不能被继承
 */


static class Student
{
    static Student()
    {
        Id = 1;
        Name = "Jack";
    }

    static private int Id;
    static public string Name { get; set; }

    static public void ShowInfo()
    {
        WriteLine($"id={id},Name={Name}");

    }
}