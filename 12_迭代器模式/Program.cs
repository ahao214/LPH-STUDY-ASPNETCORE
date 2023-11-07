using System.Collections;
using static System.Console;

// 设计模式：迭代器模式
// 目的：循环遍历输出结果

var users = new List<User>()
{
new User(){ Name ="张三"},
new User(){ Name ="李斯"},
new User(){ Name ="张二"},
new User(){ Name ="历战"},
};

var collection = new UserCollection(users.ToArray());
while (collection.HasNext())
{
    var user = (User)collection.Next();
    WriteLine(user.Name);
}

interface IIterator
{
    bool HasNext();
    object Next();
}

class UserCollection : IIterator
{
    User[] _users;
    int index;
    public UserCollection(User[] users)
    {
        _users = users;
    }

    public bool HasNext()
    {
        return index < _users.Length;
    }

    public object Next()
    {
        var instance = _users[index];
        index++;
        return instance;
    }
}


class User
{
    public string Name { get; set; }
}



// C#自带的迭代器接口
class UserCollections : IEnumerator
{
    private readonly User[] _users;
    int index = -1;

    public UserCollections(User[] users) => this._users = users;

    public object Current { get; private set; }

    public bool MoveNext()
    {
        index++;
        Current = _users[index];
        return index < _users.Length - 1;
    }

    public void Reset() => index = -1;
}