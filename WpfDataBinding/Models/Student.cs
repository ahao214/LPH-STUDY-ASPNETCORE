using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataBinding.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> Books { get; set; } = new List<string>(0);
    }
}
