// record required init 修饰


// init 属性只能在 new 的时候初始化(赋值)
// initial 
var user = new User()
{
    Id = 1,
    Name = "jack",
    Age = 5
};

// required 属性必须在 new 的时候初始化(赋值)

// record 修饰不可变的对象

// DDD: 值对象

var teacher = new Teacher("admin", "111");



record class Teacher(string Name,string Pwd);






class User
{
    public int Id { get; init; }
    public string Name { get; init; }
    public int Age { get; init; }
}
