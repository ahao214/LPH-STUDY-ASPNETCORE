using static System.Console;

Title = "扩展方法";


// 使用扩展方法
Student stu = new Student();
stu.PrintId();


// 定义扩展方法
class Student
{
    public int Id { get; set; }
}

static class Student2
{
    public static void PrintId(this Student student)
    {
        WriteLine(student.Id);
    }
}

