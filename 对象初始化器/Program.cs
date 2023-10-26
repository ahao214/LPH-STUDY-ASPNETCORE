using static System.Console;

Title = "对象初始化器";

//对象初始化
Student stu = new Student()
{
    Id = 1,
    Name = "Jack"
};


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

}