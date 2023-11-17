using static System.Console;

Title = "泛型";

Show<int>(111);
Show<double>(2.3);
Show<string>("block");


#region 泛型方法

static void Show<T>(T param)
{
    WriteLine(param.GetType().Name + " " + param);
}




#endregion