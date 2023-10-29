using static System.Console;

/*
 元组
 */

string x = "长江";
string y = "黄河";

WriteLine($"x={x},y ={y}");

//交换数据
(x, y) = (y, x);

WriteLine($"x={x},y ={y}");


// 更简洁的语法

// 定义元祖
(string, int) lubanone = ("鲁班七号", 12);

var lubantwo = ("鲁班八号", 112);

WriteLine($"姓名：{lubanone.Item1},年龄：{lubanone.Item2}");

// 使用命名字段1
var one = (name: "luba", age: 22);
WriteLine($"姓名：{one.name},age:{one.age}");

// 使用命名字段2
(string name, int age) two = ("天空", 1111);
WriteLine($"name:{two.name},age:{two.age}");


// 元组的解构
(string name, int age) = ("纣王", 234);
var (names, ages) = ("妲己", 11111);

WriteLine($"name:{name},age:{age}");
WriteLine($"name:{names},age:{ages}");

// 弃元 即放弃不需要的元素
var tuple = (1, "a", 3.123);
var (_, letter, _) = tuple;
WriteLine(letter); // 结果为a 



// 元祖作为参数
void ProcessTuple((string name,int age) person)
{
    WriteLine($"name:{person.name},age:{person.age}");
}

ProcessTuple(("Jack", 24));


// 元组作为返回类型
(int Sum,int Product) GetSumAndProduct(int a,int b)
{
    return (a + b, a * b);
}

var result = GetSumAndProduct(3, 4);
WriteLine($"和：{result.Sum},乘积：{result.Product}");








