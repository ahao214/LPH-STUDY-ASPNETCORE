using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ArchiTectRelax.Design.IOC.Examples
{
    /// <summary>
    /// 学生类
    /// </summary>
    [IOCService]
    class Student
    {
        [IOCInject]
        public Teacher teacher { get; set; }

        public void Study()
        {
            teacher.Classes();
            Console.WriteLine("学生开始学习");
        }
    }
}
