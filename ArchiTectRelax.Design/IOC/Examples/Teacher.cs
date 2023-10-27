﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace ArchiTectRelax.Design.IOC.Examples
{
    [IOCService]
    public class Teacher
    {
        public Student student { set; get; }

        public void Classes()
        {
            Console.WriteLine("老师开始上课了");
        }
    }
}