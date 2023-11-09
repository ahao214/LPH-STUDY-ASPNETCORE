using static System.Console;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

// 序列化和反序列化
// C#对象 -> JSON对象 序列化      Serialize
// JSON对象 -> C#对象 反序列化     Deserialize


// JSON

var user = new UserInfo("jack", 23, new[] { "开发者" });
var json = JsonSerializer.Serialize(user,new JsonSerializerOptions
{
       Encoder=JavaScriptEncoder.Create(UnicodeRanges.All)
});
WriteLine(json);

// 反序列化
var users = JsonSerializer.Deserialize<UserInfo>(json);
WriteLine(user);
WriteLine($"Name:{users.Name}");
WriteLine($"Age:{users.Age}");
WriteLine($"Roles:{string.Join(",", users.Roles)}");


public record UserInfo(string Name,int Age, string[] Roles);


