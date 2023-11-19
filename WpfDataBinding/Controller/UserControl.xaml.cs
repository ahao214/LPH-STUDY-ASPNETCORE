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

namespace WpfDataBinding.Controller
{
    /// <summary>
    /// UserControl.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl 
    {
        public UserControl()
        {
            InitializeComponent();

            Book book = new Book()
            {
                Id = 100,
                Name = "Go开发",
                Author = "不二"
            };

            
        }
    }
}
