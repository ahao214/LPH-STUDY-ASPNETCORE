using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmDemo.Models;

namespace WpfMvvmDemo.ViewModels
{
    public class MainViewModel
    {
        public Student Stu { get; set; } = new Student();

        public MainViewModel()
        {
            Stu.StuName = "YDT Jack";
        }






    }
}
