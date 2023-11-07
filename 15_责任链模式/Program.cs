using static System.Console;

// 设计模式：责任链模式
// 目的：层层传递，层层处理

var context = new ProcessContext();
var manager = new ProcessA();
var leader = new ProcessB();
var director = new ProcessC();

leader.Next = director;
director.Next = manager;

leader.Process(context);


class ProcessContext
{
    public string? Name { get; set; }
    public string? Next { get; set; }
}

abstract class ProcessHandler
{
    public ProcessHandler Next { get; set; }
    public abstract void Process(ProcessContext processContext);

}

class ProcessA : ProcessHandler
{
    public override void Process(ProcessContext context)
    {
        context.Name = "领导";

        WriteLine($"流程A,{context.Name}进行处理");
        Next?.Process(context);
    }
}

class ProcessB : ProcessHandler
{
    public override void Process(ProcessContext context)
    {
        context.Name = "组长";
        WriteLine($"流程B,{context.Name}进行处理");
        Next?.Process(context);
    }
}



class ProcessC : ProcessHandler
{
    public override void Process(ProcessContext context)
    {
        context.Name = "班长";
        WriteLine($"流程C,{context.Name}进行处理");
        Next?.Process(context);
    }
}