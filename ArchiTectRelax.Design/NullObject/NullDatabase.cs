using ArchiTectRelax.Design.NullObject.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiTectRelax.Design.NullObject
{
    /// <summary>
    /// 空对象数据库
    /// </summary>
    class NullDatabase : AbstractDatabase
    {
        public NullDatabase(string name)
        {
            this.DatabaseName = name;
        }

        public override string GetURL()
        {
            return "数据库不存在";
        }

    }
}
