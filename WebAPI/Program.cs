using Newtonsoft.Json.Serialization;
using WebAPI.Filter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    // 设置JSON返回日期格式
    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
    // 统一设置API的日期格式
    options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";


});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    // 设置对象类型参数默认值
    options.SchemaFilter<DefaultValueSearchFilter>();

});

// 添加跨域策略
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", opt => opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// 使用跨域策略
app.UseCors("CorsPolicy");

app.Run();
