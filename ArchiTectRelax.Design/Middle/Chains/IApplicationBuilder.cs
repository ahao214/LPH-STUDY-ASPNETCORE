using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle.Chains
{
    /// <summary>
    /// aspnetcore应用程序
    /// </summary>
    class IApplicationBuilder
    {

        /// <summary>
        /// 应用程序构造
        /// </summary>
        private IApplication application = new IApplication();


        /// <summary>
        /// 1.构建异常中间件
        /// </summary>
        /// <returns></returns>
        public IApplicationBuilder UseException()
        {
            //创建异常中间件
            Middleware middleware = new ExceptionMiddleware();

            //添加到应用程序中
            application.middlewares.Add(middleware);

            return this;

        }



        /// <summary>
        /// 2.构建身份认证中间件
        /// </summary>
        /// <returns></returns>
        public IApplicationBuilder UseAuthentication()
        {
            //创建身份认证中间件
            Middleware middleware = new AuthenticationMiddleware();

            //添加到应用程序中
            application.middlewares.Add(middleware);

            return this;

        }


        /// <summary>
        /// 3.构建授权中间件
        /// </summary>
        /// <returns></returns>
        public IApplicationBuilder UseAuthorization()
        {
            //创建授权中间件
            Middleware middleware = new AuthorizationMiddleware();

            //添加到应用程序中
            application.middlewares.Add(middleware);

            return this;

        }


        /// <summary>
        /// 4.构建404中间件
        /// </summary>
        /// <returns></returns>
        public IApplicationBuilder Use404()
        {
            //创建404中间件
            Middleware middleware = new Default404Middleware();

            //添加到应用程序中
            application.middlewares.Add(middleware);

            return this;

        }


    }
}
