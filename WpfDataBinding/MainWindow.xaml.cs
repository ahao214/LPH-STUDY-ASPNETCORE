using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDataBinding.Models;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 定义Age属性
        /// </summary>
        public int Age { set; get; } = 100;

        public Student? Stu { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // 创建学生对象
            Stu = new Student()
            {
                Id = 1001,
                Name = "Jack",
                Books= new List<string>
                {
                    "a","b","c"
                }
            };

            // 可以指定窗体绑定的数据源
            //this.DataContext = Stu;
            this.DataContext = this;
        }
    }
}
