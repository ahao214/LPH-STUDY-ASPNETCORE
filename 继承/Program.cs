using static System.Console;

Title = "继承";

/*
 
*/




Student s1 = new Student();
s1.Speak();

Student s2 = new NewStudent();
s2.Speak();

class Student
{
    public int Id { get; set; }
    public virtual void Speak()
    {
        WriteLine("说中文");
    }
}


class NewStudent : Student
{
    public string Name { get; set; }
    public void Play()
    {
        WriteLine("玩游戏");
    }

    public override void Speak()
    {
        WriteLine("说英文");
    }

}