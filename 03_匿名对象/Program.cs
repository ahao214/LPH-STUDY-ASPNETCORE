using static System.Console;

/*
 匿名对象
 */

//创建使用匿名类型对象
//var person = new { Name = "Tom", Age = 30 };
//WriteLine($"Name:{person.Name},Age:{person.Age}");



//动态类型处理匿名类型对象
//缺点:属性名写错了，也不会报错，运行时出错
//dynamic GetStudentInfo()
//{
//    return new { Name = "Jack", Age = 23 };
//}
//dynamic student = GetStudentInfo();
//WriteLine($"Name:{student.Name},Age:{student.Age}");


//指定类型接收匿名类型对象
//这个技巧只有在同一个程序集中的代码才有效
//dynamic GetStudentInfo()
//{
//    return new { Name = "Jack", Age = 23 };
//}
//var student = new { Name = "", Age = 0 };
//student = GetStudentInfo();
//WriteLine($"Name:{student.Name},Age:{student.Age}");




//通过反射获取你们类型数据项(测试匿名类型作参数)
//using System.Reflection;
//void Test(object obj)
//{
//    Type t = obj.GetType();
//    PropertyInfo? pName = t.GetProperty("Name");
//    PropertyInfo? pAge = t.GetProperty("Age");

//    WriteLine($"匿名类型：{t.Name}");
//    WriteLine($"Name:{pName?.GetValue(obj)},Age:{pAge?.GetValue(obj)}");
//}

//Test(new { Name = "Jack", Age = 22 });


//linq支持对匿名对象集合的查询处理

var person = new[] {
    new { Name="Jack",Age = 20},
    new { Name="Tom",Age = 26},
    new { Name="Jerry",Age = 24}
};

var query = from p in person where p.Age > 21 select p;
foreach (var p in query)
{
    WriteLine($"Name:{p.Name},Age:{p.Age}");
}

