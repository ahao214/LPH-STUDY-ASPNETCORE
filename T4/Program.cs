using static System.Console;
using StackExchange.Redis;
using Newtonsoft.Json;
using System.Net.Http.Headers;




var redisDB = ConnectionMultiplexer.Connect("127.0.0.1:6379").GetDatabase(0);

Product p = new Product()
{
    Id = 1,
    Name = "笔记本",
    Price = 9999,
    Stock = 100
};

// 销售数量
redisDB.StringSet("saleNum", 0);
int saleNum = Convert.ToInt32(redisDB.StringGet("saleNum"));

// 1 创建事务
var tran = redisDB.CreateTransaction();
// 2 添加事务约束(监视字段)加锁
tran.AddCondition(Condition.StringEqual("saleNum", saleNum));
while (saleNum < p.Stock)
{
    saleNum = new Random().Next(1, 10);
    redisDB.StringSetAsync("saleNum", saleNum);
    // 保存用户信息
    string id = Guid.NewGuid().ToString();
    string customer = $"用户：{id}";

    redisDB.SetAddAsync("customers", customer);

}

// 3 执行(提交)事务





class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}