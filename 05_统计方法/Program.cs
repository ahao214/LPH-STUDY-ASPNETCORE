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


// 统计英语最高分、最低分、总分、平均分
WriteLine($"最高分：{students.Max(s => s.English)}," + $"最低分：{students.Min(s => s.English)}," + $"总分：{students.Sum(s => s.English)}," + $"平均分：{students.Average(s => s.English):0.00}");

// 统计男生和女生各自英语平均分
WriteLine($"男生平均分：{students.Where(s => s.Sex == "男").Average(s => s.English):0.00}");

WriteLine($"女生平均分：{students.Where(s => s.Sex == "女").Average(s => s.English):0.00}");

// 统计英语成绩最高学员名字和乘积


ReadKey();










