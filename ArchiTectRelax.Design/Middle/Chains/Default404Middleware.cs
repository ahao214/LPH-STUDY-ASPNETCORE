using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle.Chains
{
    /// <summary>
    /// 默认404中间件
    /// </summary>
    class Default404Middleware : Middleware
    {
        private string token = "404";

        public override void HandleRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行默认404中间件");
            if (httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"默认404中间件终止了");
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
