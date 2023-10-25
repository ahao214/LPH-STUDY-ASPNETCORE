using static System.Console;

Title = "静态成员的分类";


/*
 初始静态成员可以使用静态构造方法
 */

Student.Member = 30;
WriteLine(Student.PI);


class Student
{
    public const double PI = 3.14;
    public static int Member;


}