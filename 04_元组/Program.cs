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