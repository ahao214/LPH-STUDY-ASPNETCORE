using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace T8
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // 移除原本的XML解析
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // 设置JSON序列化遇到循环引用的处理方式
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;




            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
