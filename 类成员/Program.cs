using System;

namespace 类成员
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int m1 = s1.Member = 1;
            Console.WriteLine($"实例成员：{m1}");

            Student s2 = new Student();

            //静态成员
            int m2 = Student.Member2 = 2;
            Console.WriteLine($"静态成员：{m2}");
        }
    }



    public class Student
    {
        public int Member;
        public static int Member2;
    }
}
