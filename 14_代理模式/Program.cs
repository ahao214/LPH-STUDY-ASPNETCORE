using static System.Console;


// 设计模式：代理模式
// 目的：帮你完成你没有完成的内容


var real = new RealAction();
var proxy = new ProxyAction(real);

proxy.Do();


interface IAction
{
    void Do();
}


class RealAction : IAction
{
    public void Do() => WriteLine("我是真的");
}

class ProxyAction:IAction
{
    private readonly IAction _action;
    public ProxyAction(IAction action)
    {
        _action = action;
    }

    public void Do()
    {
        WriteLine("我在真的之前");
        _action.Do();
        WriteLine("我在真的之后");
    }

}