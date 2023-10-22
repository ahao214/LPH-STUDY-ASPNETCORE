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
    class IApplication
    {
        //中间件集合
        public List<Middleware> middlewares { set; get; } = new List<Middleware>();
    }
}
