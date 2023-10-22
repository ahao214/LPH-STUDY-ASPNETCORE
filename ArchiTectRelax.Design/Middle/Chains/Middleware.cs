using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle.Chains
{
    abstract class Middleware
    {
        //下一个中间件
        public Middleware nextMiddleware { get; set; }
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="httpContext"></param>
        public abstract void HandleRequest(HttpContext httpContext);

    }
}
