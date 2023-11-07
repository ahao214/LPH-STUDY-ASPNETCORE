using System.Text;
using static System.Console;


// 设计模式：组合模式
// 目的：这就是一棵树

Node node = new Node()
{
    Name = "根",
    Children = new List<Node>()
    {
        new Node(){ Name ="子节点1"},
        new Node()
        {
            Name ="子节点2",
            Children =new List<Node>
            {
                new Node(){Name ="第二个子节点"}
            }
        }
    }
};

WriteLine(node);
ReadKey();

class Node
{
    public string Name { get; set; }
    public ICollection<Node> Children { get; set; } = new HashSet<Node>();


    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(Name);
        builder.AppendLine();
        Loop(builder, Children, 1);
        return base.ToString();
    }

    void Loop(StringBuilder builder, IEnumerable<Node> nodes, int deep)
    {
        foreach (var child in nodes)
        {
            builder.AppendFormat("|{0}{1}", new string('-', deep), child.Name);
            builder.AppendLine();
            deep++;
            Loop(builder, child.Children, deep);
        }
    }

}

