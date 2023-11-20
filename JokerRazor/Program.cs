var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


if(!app.Environment.IsDevelopment())
{
    app.UseHsts();  //��Ӱ�ȫ�����м��
}

app.UseHttpsRedirection();


app.MapGet("/", () => "Hello World!");

app.Run();
