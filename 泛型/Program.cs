using static System.Console;

Title = "泛型";

/*
 * 泛型
 * 一种通用类型，它可以定义没有明确类型的成员
 */

Student<string> s1 = new Student<string>();
s1.Id = "1";

Student<int> s2 = new Student<int>();
s2.Id = 1;


// 多个参数的泛型
Teacher<int, string, int> teacher = new Teacher<int, string, int>();



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



// 多个参数的泛型类型
class Teacher<T, S, V>
{
    public T Id { get; set; }
    public S Phone { get; set; }
    public S Name { get; set; }
    public V ShowInfo(T id)
    {
        return default;
    }

}


// 泛型接口
interface IPeople<T, S>
{
    T ShowInfo(S id);
}

class MyClass1 : IPeople<string, int>
{
    public string ShowInfo(int id)
    {
        return default;
    }
}


class MyClass2<T, S> : IPeople<T, S>
{
    public T ShowInfo(S id)
    {
        return default;
    }
}


class MyClass3<T>:IPeople<T,int>
{
    public T ShowInfo(int id)
    {
        return default;
    }
}