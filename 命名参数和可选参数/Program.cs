using static System.Console;

Title = "命名参数和可选参数";

/*
注意：
命名参数和可选参数在一起的时候
命名参数在前，可选参数在后
 */

Print(1, "jack");
//命名参数
Print(s: "Tom", a: 100);

static void Print(int a, string s)
{

}







//可选参数
WriteWord(1, "hello");
WriteWord(1);
static void WriteWord(int a ,string s="")
{

}
