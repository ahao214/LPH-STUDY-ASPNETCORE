using Ahao_Blog.Filters;
using Ahao_Blog.Options;
using Blog.Application;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

// Add services to the container.
var configuration = services.BuildServiceProvider()?.GetRequiredService<IConfiguration>();

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddApplication();

#region 注入File配置
var fileOptionsSection = configuration.GetSection(nameof(BlogFileOptions));
services.Configure<BlogFileOptions>(fileOptionsSection);

#endregion

var JwtOptionsSection = configuration.GetSection(nameof
    (JwtOptions));

services.Configure<JwtOptions>(JwtOptionsSection);
var jwt = JwtOptionsSection.Get<JwtOptions>();


// 注入方法
services.AddCurrent();

// 注入Jwt的配置
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true, // 是否在令牌期间验证签发者
            ValidateAudience = true, // 是否验证接收者
            ValidateLifetime = true,// 是否验证失效时间
            ValidateIssuerSigningKey = true,// 是否验证签名
            ValidAudience = jwt.Audience,   // 接收者
            ValidIssuer = jwt.Issuer,    // 签发者
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey!)) //秘钥
        };
    });

// 添加过滤器
builder.Services.AddMvcCore(x =>
{
    x.Filters.Add<ResponseFilter>();    // 响应格式过滤器
    x.Filters.Add<ExceptionFilter>();   // 异常过滤器
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.UseStaticFiles();
app.Run();
