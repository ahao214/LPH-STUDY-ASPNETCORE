
using ArchiTectRelax.Design.Factory.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Factory
{
    public class ShapeFactory
    {
        //扩展区域字典集合
        private Dictionary<string, Type> keyValues = new Dictionary<string, Type>();

        public IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
