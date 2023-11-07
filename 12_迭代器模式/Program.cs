using static System.Console;

// 设计模式：迭代器模式
// 目的：循环遍历输出结果



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

}