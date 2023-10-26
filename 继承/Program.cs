using static System.Console;

Title = "继承";

/*
 * 继承作用：继承关系
 * 继承作用：代码重用
 * 继承作用：多态性
 * 继承作用：抽象
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

#region 继承作用：代码重用

class Teacher
{
    public int Id { get; set; }
}

class OldTeacher : Teacher
{
    public string Name { get; set; }
}

#endregion

#region 继承作用：多态性

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

#endregion



#region 继承作用：抽象

public abstract class Animal
{
    public abstract void Speak();
}

public class Pet : Animal
{
    public override void Speak()
    {
        WriteLine("宠物说话");
    }

    public void Play()
    {
        WriteLine("宠物玩");
    }
}




#endregion