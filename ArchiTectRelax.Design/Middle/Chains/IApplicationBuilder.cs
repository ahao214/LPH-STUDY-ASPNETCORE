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
        //public IApplicationBuilder Use404()
        //{
        //    //创建404中间件
        //    Middleware middleware = new Default404Middleware();

        //    //添加到应用程序中
        //    application.middlewares.Add(middleware);

        //    return this;

        //}

        /// <summary>
        /// 构建中间件(按照责任链形式添加)
        /// </summary>
        /// <returns></returns>
        public Middleware Build()
        {
            //创建默认404中间件
            Middleware middlewareFirst = new Default404Middleware();

            //遍历中间件添加到后面
            List<Middleware> lst = application.middlewares;
            lst.Reverse();
            foreach (Middleware mw in lst)
            {
                //添加下一个中间件
                middlewareFirst.nextMiddleware = mw;

                //将默认中间件进行替换
                middlewareFirst = mw;
            }
            //返回中间件
            return middlewareFirst;
        }

    }
}
