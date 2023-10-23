using static System.Console;

Title = "方法重载";
/*
方法的重载
一同——方法名相同
三不同——参数个数、类型、顺序不同
 */

Student.Print(1);
Student.Print(1, "student");
Student.Print("Tom", 23);


public class Student
{
    public static void Print(int a)
    {

    }

    public static void Print(int a, string s)
    {

    }

    public static void Print(string s, int a)
    {

    }
}

