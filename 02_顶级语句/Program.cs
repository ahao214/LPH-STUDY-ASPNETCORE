using static System.Console;
using System.Reflection;

/*
 顶级语句
 */

//获取当前代码所在方法名和类名

WriteLine(MethodBase.GetCurrentMethod().Name);
WriteLine(MethodBase.GetCurrentMethod().DeclaringType.Name);



Test();

void Test()
{
    WriteLine("good good study,day day up");
}