using static System.Console;

// 设计模式：备忘录模式
// 目的：保存历史记录，随时恢复


var user = new User { Name = "第一次记录" };
var history = new  History();
history.Add(user.Save());

user.Name = "修改了值";
history.Add(user.Save());

user.Name = "第三次修改了";
history.Add(user.Save());

WriteLine($"获取第二次修改：{history.Get(1).User.Name}");
WriteLine($"获取第一次修改：{history.Get(0).User.Name}");

ReadKey();


class User
{
    public string Name { get; set; }
    public Momento Save() => new(new() { Name = Name });
    public User Restor(Momento momento) => momento.User;


}


class Momento
{
    public Momento(User user)
    {
        User = user;
    }
    public User User { get; set; }
}

class History
{
    List<Momento> lsts { get; set; } = new();
    public void Add(Momento momento)=>lsts.Add(momento);
    public Momento Get(int version) => lsts[version]; 


}