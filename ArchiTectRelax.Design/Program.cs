using ArchiTectRelax.Design.Iterator;
using ArchiTectRelax.Design.Iterator.Examples;
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
for (IIterator iter = lst.GetIterator(); iter.HasNext();)
{
    string name = (string)iter.Next();
    WriteLine("Name:" + name);
}



#endregion