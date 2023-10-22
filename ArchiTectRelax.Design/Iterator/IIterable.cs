using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.Iterator
{
    public interface IIterable
    {
        /// <summary>
        /// 获取迭代器
        /// </summary>
        /// <returns></returns>
        public IIterator GetIterator();


    }
}
