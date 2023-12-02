using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YDT_IOCS.IOCS
{
    /// <summary>
    /// IOC工厂
    /// </summary>
    public class IOCFactory
    {
        public IOCFactory()
        {
            Assembly assembly = Assembly.Load("YDT_IOCS");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                // 1 创建对象
                object _object = Activator.CreateInstance(type);

            }


        }

    }
}
