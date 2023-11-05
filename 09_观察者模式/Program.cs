using static System.Console;

Title = "观察者模式";

/*
设计模式：观察者模式
目的：让下面的对象一致的行动
*/

var t = new Teacher();
t.Add(new Action1());
t.Add(new Action2());

// 调用观察者的指令
t.Command();



interface IAction
{
    void Do();
}


class Action1 : IAction
{
    public void Do() => WriteLine("Action1 做了行为");
}

class Action2 : IAction
{
    public void Do() => WriteLine("Action2 做了行为");
}


class Teacher
{
    List<IAction> actions = new List<IAction>();

    public void Add(IAction action)
    {
        actions.Add(action);
    }

    public void Remove(IAction action)
    {
        actions.Remove(action);
    }

    public void Command()
    {
        actions.ForEach(action => action.Do());
    }

}