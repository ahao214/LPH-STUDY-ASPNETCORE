using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Factory.Examples
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("画出一个矩形区域");
        }
    }
}
