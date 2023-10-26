using static System.Console;

Title = "类型成员之索引器";


/*
数组是存储在一块连续的存储空间中,所以高效

索引器可以定义自己的逻辑更灵活
*/

// 成员访问索引方式
Student stu = new Student();
stu["Name"] = "Castle编程";
stu["Phone"] = "110";



Teacher tea = new Teacher();
tea[0] = "H老师";
tea[1] = "111";


class Student
{
    public string Name { get; set; }
    public string Phone { get; set; }

    public string this[string index]
    {
        set
        {
            switch (index)
            {
                case "Name":
                    Name = value;
                    break;
                case "Phone":
                    Phone = value;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("index");
            }
        }
        get
        {
            switch (index)
            {
                case "Name":
                    return Name;
                case "Phone":
                    return Phone;
                default:
                    throw new ArgumentOutOfRangeException("index");
            }
        }
    }
}


// 简化索引器
class Teacher
{
    public string[] Data;

    public string this[int index]
    {
        set
        {
            Data[index] = value;
        }
        get
        {
            return Data[index];
        }
    }
}