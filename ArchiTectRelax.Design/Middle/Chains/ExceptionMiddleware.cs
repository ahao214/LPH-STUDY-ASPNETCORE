using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle.Chains
{
    class ExceptionMiddleware : Middleware
    {
        private string token = "exception";

        public override void HandleRequest(HttpContext httpContext)
        {
            Console.WriteLine($"执行异常中间件");
            if (httpContext.httpRequest.requestUrl.Contains(token))
            {
                Console.WriteLine($"异常中间件终止了");
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
