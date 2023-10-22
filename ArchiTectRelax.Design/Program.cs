using ArchiTectRelax.Design.Iterator;
using ArchiTectRelax.Design.Iterator.Examples;
using ArchiTectRelax.Design.Middle.Chains;
using ArchiTectRelax.Design.NullObject.Examples;
using static System.Console;
using ArchiTectRelax.Design.Middle;


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
//AbstractDatabase c1 = DatabaseFactory.GetDatabase("mysql");
//AbstractDatabase c2 = DatabaseFactory.GetDatabase("sqlserver");
//AbstractDatabase c3 = DatabaseFactory.GetDatabase("oarcle");
//AbstractDatabase c4 = DatabaseFactory.GetDatabase("redis");

//Console.WriteLine("工厂切换数据库切换");
//Console.WriteLine(c1.GetURL());
//Console.WriteLine(c2.GetURL());
//Console.WriteLine(c3.GetURL());
//Console.WriteLine(c4.GetURL());




#endregion



#region Middleware实现原理

//1.默认中间件
Middleware m1 = new Default404Middleware();
Middleware m2 = new ExceptionMiddleware();
Middleware m3 = new AuthenticationMiddleware();
Middleware m4 = new AuthorizationMiddleware();


//2.设置调用关系
m1.nextMiddleware = m2;
m2.nextMiddleware = m3;
m3.nextMiddleware = m4;

//3.执行
m1.HandleRequest(new HttpContext());

#endregion