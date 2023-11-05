using static System.Console;



/*
设计模式：中介者模式
目的：由中间者来负责对接双方的交互

模型：房东<---> 中介 <---> 房客
 */


var landLoad = new User("房东");
var tenant = new User("房客");

Mediator mediator = new Mediator();
mediator.Trade(1000, landLoad, tenant);


class User
{
    public User(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int Amount { get; set; }
}

class Mediator
{
    public void Trade(int amount,User user1,User user2)
    {
        user1.Amount += amount;
        user2.Amount -= amount;

        WriteLine($"{user1.Name}增加了{amount}元,结余是:{user1.Amount}");
        WriteLine($"{user2.Name}增加了{amount}元,结余是:{user2.Amount}");
    }
}