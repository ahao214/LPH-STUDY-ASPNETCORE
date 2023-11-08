// record required init 修饰


// init 属性必须在 new 的时候初始化(赋值)
// initial 

var user = new User()
{
    Id = 1,
    Name = "jack",
    Age = 5
};

class User
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int Age { get; init; }
}
