using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmDemo.Models;
using WpfMvvmDemo.Common;

namespace WpfMvvmDemo.ViewModels
{
    public class MainViewModel : NotificationObject
    {
        //public Student? Stu { get; set; } = new Student();

        private Student? stu = new Student();
        public Student Stu
        {
            get { return stu!; }
            set
            {
                stu = value;
                OnPropertyChanged(nameof(Stu));
            }
        }




        public ReplyCommand? ClickCommand
        {
            get => new ReplyCommand
            {
                DoExecute = new Action<object>(UpdateStudentName)
            };
        }




        public MainViewModel()
        {
            Stu.Name = "YDT Jack";
        }

        public void UpdateStudentName(object? parameter)
        {
            Stu!.Name = "hello jack";
            //完成了对象的变化
            Stu = (Student?)Stu.Clone()!;
        }




    }
}
