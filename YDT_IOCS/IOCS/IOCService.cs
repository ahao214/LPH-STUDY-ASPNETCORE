using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDT_IOCS.IOCS
{
    /// <summary>
    /// IOCService 特性
    /// 规则：被标注的类型，才能够被创建为对象
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class IOCService : Attribute
    {
        public IOCService()
        {

        }

    }
}
