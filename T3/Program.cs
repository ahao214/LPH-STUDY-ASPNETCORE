using static System.Console;
using T3;
using StackExchange.Redis;
using Newtonsoft.Json;


Product product = new Product()
{
    Id = 1,
    Name = "苹果",
    Price = 89.56
};

// 链接redis
IDatabase redisDB = ConnectionMultiplexer.Connect("127.0.0.1:6379").GetDatabase(0);

// 字符串
redisDB.StringSet("name", "joker");
redisDB.StringGet("name");


redisDB.StringSet("p", JsonConvert.SerializeObject(product));   //写对象
JsonConvert.DeserializeObject<Product>(redisDB.StringGet("p")); // 读对象

// 哈希表
redisDB.HashSet("prod1", "name", "手机");
redisDB.HashSet("prod1", "price", "299");

redisDB.HashGet("prod1", "name");
redisDB.HashGet("prod1", "price");


// 列表 list
redisDB.ListRightPush("books", "读者");
redisDB.ListRightPush("books", "意林");
redisDB.ListRightPush("books", "NBA");

redisDB.ListRightPop("books");  // 删除
redisDB.ListGetByIndex("books", -1);    // 读

WriteLine(redisDB.ListGetByIndex("books", -1));                                         

// 集合 set
redisDB.SetAdd("sports", "篮球");
redisDB.SetAdd("sports", "足球");
redisDB.SetAdd("sports", "网球");

// 有序集合 sortset
redisDB.SortedSetAdd("subjects", "语文", 1);
redisDB.SortedSetAdd("subjects", "数学", 2);
redisDB.SortedSetAdd("subjects", "英语", 3);


ReadKey();

