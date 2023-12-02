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
    /// 1 创建对象
    /// 2 存储对象：三种容器(List Set Dictionary) 使用 Dictionary
    /// 3 获取对象
    /// </summary>
    public class IOCFactory
    {
        // 创建字典
        private Dictionary<string, object> IOCS = new Dictionary<string, object>();


        public IOCFactory()
        {
            Assembly assembly = Assembly.Load("YDT_IOCS");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                // 1 创建对象
                object _object = Activator.CreateInstance(type);

                // 2 存储对象
                IOCS.Add(type.FullName, _object);





            }


        }


        /// <summary>
        /// 3 获取对象
        /// </summary>
        public object GetObject(string fullName)
        {
            return IOCS[fullName];

        }

    }
}
