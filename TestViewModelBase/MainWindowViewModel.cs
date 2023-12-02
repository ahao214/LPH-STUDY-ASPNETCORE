﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestViewModelBase
{
    public class MainWindowViewModel : ViewModelBase
    {
        private List<Student> _students = new List<Student>();

        public List<Student> MyDataSource
        {
            get { return _students; }
            set { _students = value; RaisePropertyChanged(() => MyDataSource); }
        }


        public RelayCommand ApplyCommand { get; set; }  



        private void Apply()
        {
            MessageBox.Show("可以申请了");

        }



        public MainWindowViewModel()
        {
            InitData();
            ApplyCommand = new RelayCommand(Apply);
        }

        private void InitData()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student stu = new Student()
                {
                    Name = "liu" + (i + 1).ToString(),
                    Grade = i + 1,
                    Major = "专业" + (i + 1).ToString(),
                    Age = 10 + i
                };
                students.Add(stu);
            }
            MyDataSource = students;
        }



    }
}