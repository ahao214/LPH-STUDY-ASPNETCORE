var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


if(!app.Environment.IsDevelopment())
{
    app.UseHsts();  //添加安全访问中间件
}

app.UseHttpsRedirection();


app.MapGet("/", () => "Hello World!");

app.Run();
