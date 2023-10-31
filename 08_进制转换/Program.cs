using static System.Console;

Title = "进制转换";

// 直接使用二进制与十六进制
int i = 0b1010;
i = 0x1a;
WriteLine(i);

// 十进制转2 8 16 进制
int x = 16;
WriteLine(Convert.ToString(x, 2));
WriteLine(Convert.ToString(x, 8));
WriteLine(Convert.ToString(x, 16));


// 二进制，八进制，十六进制字符串转十进制
WriteLine(Convert.ToInt32("1010", 2));
WriteLine(Convert.ToInt32("10", 8));
WriteLine(Convert.ToInt32("1a", 16));


ReadKey();