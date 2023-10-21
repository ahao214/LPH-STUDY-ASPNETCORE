using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Iterator
{
    /// <summary>
    /// 迭代器接口
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// 判断是否还有只
        /// </summary>
        /// <returns></returns>
        public bool HasNext();

        /// <summary>
        /// 获取下一个值
        /// </summary>
        /// <returns></returns>
        public object Next();
    }
}
