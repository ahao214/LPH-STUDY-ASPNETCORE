using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Iterator.Examples
{
    public class ListData
    {
        public static string[] names = { "张三", "李斯", "王五", "溜溜", "和三" };


        public string[] GetNames()
        {
            return names;
        }


        /// <summary>
        /// 获取迭代器接口
        /// </summary>
        /// <returns></returns>
        public IIterator GetIterator()
        {
            return new ListIterator();
        }

        /// <summary>
        /// List集合内部迭代器
        /// </summary>
        private class ListIterator : IIterator
        {
            int index;
            public bool HasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            /// 获取集合中数据
            /// </summary>
            /// <returns></returns>
            public object Next()
            {
                if (this.HasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }
    }


}
