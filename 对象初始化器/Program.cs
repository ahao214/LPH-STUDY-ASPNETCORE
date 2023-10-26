using static System.Console;

Title = "对象初始化器";

/*
使用初始化器,可以减少输入,提高编码效率
 */

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