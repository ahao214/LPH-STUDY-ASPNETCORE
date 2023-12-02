using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDT_IOCS.IOCS
{
    [IOCService]
    public class Student
    {
        public Teacher teacher { get; set; }

        //public School school { get; set; }
        public void Study()
        {
            teacher.Classes();
            Console.WriteLine("学生开始学习了");
        }


    }
}
