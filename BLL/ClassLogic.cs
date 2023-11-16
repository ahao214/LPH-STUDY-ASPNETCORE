using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ClassLogic
    {
        ClassService classService = new ClassService();

        public bool AddClass(string className)
        {
            return classService.AddClass(className);
        }

    }
}
