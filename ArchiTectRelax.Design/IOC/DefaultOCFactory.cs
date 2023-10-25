using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections.Generic;


namespace ArchiTectRelax.Design.IOC
{
    class DefaultOCFactory
    {
        /// <summary>
        /// 1、IOC容器(存储对象)
        /// </summary>
        private Dictionary<string, object> iocContainer = new Dictionary<string, object>();



        /// <summary>
        /// 创建IOC工厂
        /// 1、创建对象 
        /// 2、存储对象
        /// 3、对象属性赋值
        /// 
        /// 
        /// 特性：过滤 全部都是有用Type
        /// </summary>

        public DefaultOCFactory()
        {
            //1、加载项目中所有类型(反射类型的集合)           
            Assembly ass = Assembly.Load("ArchiTectRelax.Design");
            //2、使用反射从程序集获取对象类型
            Type[] types = ass.GetTypes();

            foreach (var type in types)
            {
                //3、创建对象    
                object oj = Activator.CreateInstance(type);

                //3.1 对象属性赋值，反射(Teacher)
                PropertyInfo[] propertyInfos = type.GetProperties();
                foreach(var item in propertyInfos)
                {
                    //3.2 通过反射赋值(teacher对象从哪里来?)
                    foreach (var type1 in types)
                    {
                        if (item .PropertyType.Name .Equals (type1.Name))
                        {
                            //3.3 通过反射创建Teacher
                            object oj1 = Activator.CreateInstance(type1);
                            propertyInfos.SetValue(oj, oj1);
                        }
                    }                   
                }

                //4、存储对象
                iocContainer.Add(type.Name, oj);
            }
        }

    }
}
