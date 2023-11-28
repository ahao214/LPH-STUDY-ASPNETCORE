using Masa.BuildingBlocks.Data.UoW;
using Masa.BuildingBlocks.Ddd.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "VideoApp", Version = "v1", Contact = new Microsoft.OpenApi.Models.OpenApiContact { Name = "VideoApp", } });
        foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml")) options.IncludeXmlComments(item, true);
        options.DocInclusionPredicate((docName, action) => true);
    })
    .AddEventBus()
    .AddMasaDbContext<VideoDbContext>(opt =>
    {
        opt.UseNpgsql();
    })
    .AddDomainEventBus(options =>
    {
        options.UseEventBus()
        .UseUoW<VideoDbContext>()
        .UseRepository<VideoDbContext>();
    })
    .AddAutoInject()
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "Post" });

app.UseMasaExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger().UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "VideoApp"));

    #region MigrationDb
    //using var context = app.Services.CreateScope().ServiceProvider.GetService<ExampleDbContext>();
    //{
    //    context!.Database.EnsureCreated();
    //}
    #endregion
}

app.Run();
