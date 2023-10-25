
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

        //json文件
        //字典
        //反射

        /*
         分布式环境问题
        1、配置中心
        redis 消息队列
         */

        
        public ShapeFactory ()
        {
            //1、加载json文件
            //2、将区域实现类填充到字典中
            
        }

        public IShape GetShape(string shapeType)
        {
            //从字典获取，反射创建
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
