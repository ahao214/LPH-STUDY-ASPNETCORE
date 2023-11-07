using static System.Console;



// 设计模式：装饰器模式
// 目的：重用功能并增加新功能

new Anchor().Inner();
WriteLine();

new Bold(new Anchor()).Inner();
WriteLine();

new Italic(new Bold(new Anchor())).Inner();
WriteLine();



abstract class HtmlElement
{
    public abstract void Inner();

    protected abstract string TagName { get; }
}


class Anchor : HtmlElement
{
    protected override string TagName => "a";


    public override void Inner()
    {
        WriteLine("<{0}Anchor</0>", TagName);
    }
}


class Paramgraph : HtmlElement
{
    protected override string TagName => "p";


    public override void Inner()
    {
        WriteLine("<{0}Paragraph</0>", TagName);
    }
}

//装饰器
abstract class Decorator : HtmlElement
{
    private readonly HtmlElement _element;

    public Decorator(HtmlElement element)
    {
        this._element = element;
    }

    public override void Inner()
    {
        Write($"<{TagName}>");
        _element.Inner();
        WriteLine($"</{TagName}>");
    }
}


class Bold : Decorator
{
    public Bold(HtmlElement element) : base(element)
    { }
    protected override string TagName => "b";
}

class Italic : Decorator
{
    public Italic(HtmlElement element) : base(element)
    { }
    protected override string TagName => "b";
}