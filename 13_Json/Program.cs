using static System.Console;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

// 序列化和反序列化
// C#对象 -> JSON对象 序列化      Serialize
// JSON对象 -> C#对象 反序列化     Deserialize


// JSON

//var user = new UserInfo("jack", 23, new[] { "开发者" });
//var json = JsonSerializer.Serialize(user,new JsonSerializerOptions
//{
//       Encoder=JavaScriptEncoder.Create(UnicodeRanges.All)
//});
//WriteLine(json);

//// 反序列化
//var users = JsonSerializer.Deserialize<UserInfo>(json);
//WriteLine(user);
//WriteLine($"Name:{users.Name}");
//WriteLine($"Age:{users.Age}");
//WriteLine($"Roles:{string.Join(",", users.Roles)}");


var readers = new StreamReader("demo.json");
var jsons = readers.ReadToEnd();
var list = JsonSerializer.Deserialize<List<UserInfo>>(jsons);
foreach (var u in list)
{
    WriteLine($"Name:{u.Name}");
    WriteLine($"Age:{u.Age}");
    WriteLine($"Roles:{string.Join(",", u.Roles)}");
}


// 读取demo1.json
var reader1 = new StreamReader("demo1.json");
var json1 = reader1.ReadToEnd();
var list1 = JsonSerializer.Deserialize<Dictionary<string, UserInfo>>(json1);
foreach (var u1 in list1)
{
    WriteLine($"Id:{u1.Key}");
    WriteLine($"Name:{u1.Value.Name}");
    WriteLine($"Age:{u1.Value.Age}");
    WriteLine($"Roles:{string.Join(",", u1.Value.Roles)}");
}




public record UserInfo(string Name, int Age, string[] Roles);


