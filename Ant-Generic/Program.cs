using static System.Console;

Title = "泛型";

List<int> lst = new List<int>();
lst.Add(1);
int i = lst[0];
WriteLine(i);

Show<int>(111);
Show<double>(2.3);
Show<string>("block");

ListBlock<int> lstBlock = new ListBlock<int>();
lstBlock.Add(1);
lstBlock.Add(2);

ListBlock<string> strBlock = new ListBlock<string>();
strBlock.Add("kuteng");
strBlock.Add("block");

#region 泛型方法

static void Show<T>(T param)
{
    WriteLine(param.GetType().Name + " " + param);
}




#endregion


#region 泛型类

public class ListBlock<T>
{
    private ListBlock<T> _list;
    public void Add(T item)
    {
        _list.Add(item);
    }

}

#endregion
