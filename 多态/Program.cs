using static System.Console;

Title = "多态";


//多态的形成
Student s1 = new Student();
s1.Speak();

Student s2 = new NewStudent();
s2.Speak();

Student s3 = new NewStudent2();
s3.Speak();






class Student
{
    public virtual void Speak()
    {
        WriteLine("说中文");
    }
}

class NewStudent:Student
{
    public override void Speak()
    {
        WriteLine("说英文");
    }
}

class NewStudent2 : Student
{
    public override void Speak()
    {
        WriteLine("说俄语");
    }
}