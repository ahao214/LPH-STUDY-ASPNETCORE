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

var configurationSection = configuration.GetSection(nameof
    (JwtOptions));

services.Configure<JwtOptions>(configurationSection);
var jwt = configurationSection.Get<JwtOptions>();

services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true, // �Ƿ��������ڼ���֤ǩ����
            ValidateAudience = true, // �Ƿ���֤������
            ValidateLifetime = true,// �Ƿ���֤ʧЧʱ��
            ValidateIssuerSigningKey = true,// �Ƿ���֤ǩ��
            ValidAudience = jwt.Audience,   // ������
            ValidIssuer = jwt.Issuer,    // ǩ����
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey!)) //��Կ
        };
    });

// ע�������
builder.Services.AddMvcCore(x =>
{
    x.Filters.Add<ResponseFilter>();
    x.Filters.Add<ExceptionFilter>();
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

app.Run();
