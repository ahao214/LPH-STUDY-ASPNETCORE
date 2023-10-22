using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Middle
{
    /// <summary>
    /// HTTP上下文类(用于获取HttpRequest和HttpResponse)
    /// </summary>
    class HttpContext
    {
        //请求输入类
        public HttpRequest httpRequest { get; set; }
        //请求响应输入
        public HttpResponse httpResponse { get; set; }
    }
}
