using static System.Console;

// 设计模式：命令模式

var person = new Person();
var command = new WashCommand(person);
command.Execute();

ReadKey();

class Person
{
    public void WashHand()
    {
        WriteLine("洗手");
    }
}


interface ICommand
{
    void Execute();
}

class WashCommand : ICommand
{
    private readonly Person _person;
    public WashCommand(Person person)
    {
        _person = person;
    }

    public void Execute()
    {
        _person.WashHand();
    }
}



