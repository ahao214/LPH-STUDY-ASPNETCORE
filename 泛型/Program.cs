using static System.Console;

Title = "泛型";



Student<string> s1 = new Student<string>();
s1.Id = "1";

Student<int> s2 = new Student<int>();
s2.Id = 1;





class Student1
{
    public int Id { get; set; } 
}


class Student2
{
    public int Id { get; set; }
}

class Student<T>
{
    public T Id { get; set; }
}

