

// 反射
// 一切从 Type 开始
// 动态操作对象


var user = new User();
user.Name = "tom";
user.Id = 1;

user.GetType()
    .GetProperties()
    .ToList()
    .ForEach(item =>
    {
        var name = item.Name;
        item.GetValue(user);
    });


class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}