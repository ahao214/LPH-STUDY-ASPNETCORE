using ArchiTectRelax.Design.Iterator;
using ArchiTectRelax.Design.Iterator.Examples;
using ArchiTectRelax.Design.NullObject.Examples;
using static System.Console;

#region 迭代器设计模式

ListData lst = new ListData();
//for循环
//string[] names = lst.GetNames();
//for (int i = 0; i < names.Length; i++)
//{
//    WriteLine("Name:" + names[i]);
//}


//迭代器遍历
//for (IIterator iter = lst.GetIterator(); iter.HasNext();)
//{
//    string name = (string)iter.Next();
//    WriteLine("Name:" + name);
//}



#endregion


#region 空对象模式

//1.直接切换
//AbstractDatabase abstractDatabase1 = new MySqlDatabase("mysql");
//AbstractDatabase abstractDatabase2 = new SqlServerDatabase("sqlserver");
//AbstractDatabase abstractDatabase3 = new OarcleDatabase("oarcle");

//Console.WriteLine("工厂切换数据库切换");
//Console.WriteLine(abstractDatabase1.GetURL());
//Console.WriteLine(abstractDatabase2.GetURL());
//Console.WriteLine(abstractDatabase3.GetURL());


//2.工厂模式切换
AbstractDatabase c1 = DatabaseFactory.GetDatabase("mysql");
AbstractDatabase c2 = DatabaseFactory.GetDatabase("sqlserver");
AbstractDatabase c3 = DatabaseFactory.GetDatabase("oarcle");
AbstractDatabase c4 = DatabaseFactory.GetDatabase("redis");

Console.WriteLine("工厂切换数据库切换");
Console.WriteLine(c1.GetURL());
Console.WriteLine(c2.GetURL());
Console.WriteLine(c3.GetURL());
Console.WriteLine(c4.GetURL());




#endregion
