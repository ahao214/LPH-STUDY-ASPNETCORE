using static System.Console;

Title = "分部类";

/*
优点：
代码组织
代码复用
模块化开发
大型项目开发

某个文件特别大的时候,可以使用分部类




*/





partial class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

partial class Student
{
    public void ShowInfo()
    {
        WriteLine(Id);
        WriteLine(Name);
    }
}