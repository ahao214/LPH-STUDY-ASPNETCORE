using Video.EntityFrameworkCore;
using Serilog.Events;
using Serilog;
using Video.HttpApi.Host.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Video.Application;
using Video.Application.Contract.UserInfos;
using FreeRedis;
using Microsoft.Extensions.DependencyInjection;




Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .ReadFrom.Configuration(new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Producton"}.json",
    optional: true).Build())
    .Enrich.FromLogContext()
    .WriteTo.Async(c => c.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "/log", "log"),
    rollingInterval: RollingInterval.Day))// д����־�ļ�
    .WriteTo.Async(c => c.Console())
    .CreateLogger();


var builder = WebApplication.CreateBuilder(args);

// ʹ��Serilong
builder.Host.UseSerilog();
//Log.Logger.Information("��ʼʹ����־");

builder.Services.AddVideoApplication();

var configuration = builder.Services.BuildServiceProvider().GetRequiredService<IConfiguration>();
var jwtsection = configuration.GetSection(nameof(JWTOptions));

builder.Services.Configure<JWTOptions>(jwtsection);

var jwt = jwtsection.Get <JWTOptions>();
// ע��JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateIssuer = true,// �Ƿ��������ڼ���֤ǩ����
            ValidateAudience = true,// �Ƿ���֤������
            ValidateLifetime = true,// �Ƿ���֤ʧЧʱ��
            ValidateIssuerSigningKey = true,// �Ƿ���֤ǩ��
            ValidAudience = jwt.Audience,    // ������
            ValidIssuer = jwt.Issuer,  //ǩ����
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey!))
        };

    });


builder.Services.AddSingleton(new RedisClient(configuration["RedisConnection"]));

builder.Services.AddVideoEntityFrameworkCor();




// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.UseAuthentication();    // ��֤
app.UseAuthorization();     // ��Ȩ

//app.MapGet("/weatherforecast", () =>
//{
//    var forecast = Enumerable.Range(1, 5).Select(index =>
//        new WeatherForecast
//        (
//            DateTime.Now.AddDays(index),
//            Random.Shared.Next(-20, 55),
//            summaries[Random.Shared.Next(summaries.Length)]
//        ))
//        .ToArray();
//    return forecast;
//})
//.WithName("GetWeatherForecast");


app.MapGet("/ok", (IOptions<JWTOptions> options) =>
{
    var jwt = options.Value;
    Claim[] claims = new Claim[] {
    new Claim (ClaimsIdentity.DefaultRoleClaimType,"x")
    };

    var keyBytes = Encoding.UTF8.GetBytes(jwt.SecretKey);
    var cred = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256);

    var jwtSecurityToken = new JwtSecurityToken
    (
        jwt.Issuer,// ǩ����
        jwt.Audience,// ������
        claims, //payload
        expires: DateTime.Now.AddMinutes(jwt.ExpireMinutes),// ����ʱ��
        signingCredentials: cred);// ����
    var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
    return token;
});

app.MapGet("/authorization", [Authorize] () => "ok");
app.MapGet("/admin", [Authorize(Roles = "admin")] () => "ok");
app.MapGet("/x", [Authorize(Roles = "/x")] () => "ok");

app.MapGet("/user-info",async (IUserInfoService userInfoService)=>await userInfoService.GetAsync());


app.MapControllers();
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}