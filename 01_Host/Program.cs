using Microsoft.Extensions.Hosting;


/*
 ASP.NET Core的运行生命周期
Program->各种环境的配置->配置服务(依赖注入)->构建ApplicationBuilder->中间件->运行/结束->Program
 */

var builder = Host.CreateApplicationBuilder(args);
var host = builder .Build();

host.Run ();
