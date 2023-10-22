using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle.Chains
{
    /// <summary>
    /// 授权中间件
    /// </summary>
    class AuthorizationMiddleware : Middleware
    {
        /// <summary>
        /// 中间件是否终止条件
        /// </summary>
        private string token = "author_token";


        public override void HandleRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行授权中间件");
            //判断请求url是否包含token，包含则终止
            if(httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"授权中间件终止了");
                return;
            }
            else
            {
                //执行下一个中间件
                nextMiddleware.HandleRequest(httpContext);

            }

        }

    }
}
