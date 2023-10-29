using _05_统计方法;
using static System.Console;

Title = "统计方法";


int[] arr = { 2, 3, 3, 3, 3, 31, 2, 345, 45, 34, 78, 123, 45, 67, 90, 8 };

WriteLine($"和：{arr.Sum()},平均数：{arr.Average():0.00},数量：{arr.Count()},最大值：{arr.Max()},最小值：{arr.Min()}");


List<Student> students = new List<Student>()
{
new Student{Id=1,Name ="包青天",Age = 22,Sex ="男",English =100},

new Student{Id=2,Name ="展昭",Age = 34,Sex ="男",English =98},

new Student{Id=1,Name ="张龙",Age = 23,Sex ="男",English =77},

new Student{Id=1,Name ="赵虎",Age = 25,Sex ="男",English =45},

new Student{Id=1,Name ="王超",Age = 27,Sex ="男",English =67},
new Student{Id=1,Name ="马汉",Age = 30,Sex ="男",English =78},

new Student{Id=1,Name ="苏小妹",Age = 18,Sex ="女",English =100},




};


ReadKey();










