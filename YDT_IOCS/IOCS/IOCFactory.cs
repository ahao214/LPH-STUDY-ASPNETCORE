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
    /// 4 依赖注入(对象属性赋值)
    /// 5 对象过滤
    ///     只创建需要的对象
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
                // 5 对象过滤
                IOCService iocservice = type.GetCustomAttribute<IOCService>();
                if (iocservice != null)
                {

                    // 1 创建对象
                    object _object = Activator.CreateInstance(type);


                    // 4 对象属性赋值(依赖注入)
                    //PropertyInfo propertyInfo= type.GetProperty("teacher");
                    //propertyInfo.SetValue(_object, new Teacher());

                    //PropertyInfo propertyInfo1 = type.GetProperty("school");
                    //propertyInfo1.SetValue(_object, new School());

                    PropertyInfo[] properties = type.GetProperties();
                    foreach (PropertyInfo property in properties)
                    {
                        // 遍历Type[]
                        foreach (var item in types)
                        {
                            // 判断item
                            if (property.PropertyType.Equals(item))
                            {
                                // 创建item对象
                                object obj = Activator.CreateInstance(item);

                                // 赋值(依赖注入)
                                property.SetValue(_object, obj);
                            }
                        }

                    }
                    // 2 存储对象
                    IOCS.Add(type.FullName, _object);
                }
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
