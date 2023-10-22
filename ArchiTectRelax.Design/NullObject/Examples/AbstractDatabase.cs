using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject.Examples
{
    /// <summary>
    /// 抽象数据库类
    /// </summary>
    public abstract class AbstractDatabase
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        protected string DatabaseName;

        /// <summary>
        /// 数据库URL
        /// </summary>
        /// <returns></returns>
        public abstract string GetURL();

    }

}
