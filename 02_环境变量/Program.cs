using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Memory;

// 环境变量

var builder = Host.CreateDefaultBuilder();
builder.UseEnvironment("UAT");

builder.ConfigureHostConfiguration(configure =>
{
    configure.AddEnvironmentVariables("myenv")
    .AddJsonFile("test.json");
});

var host = builder.Build();
var config = host.Services.GetRequiredService<IConfiguration>();
var logger = host.Services.GetRequiredService<ILogger<Program>>();

logger.LogInformation("My ENV IS:{0}", config.GetValue<string>("key"));

host.Run();



