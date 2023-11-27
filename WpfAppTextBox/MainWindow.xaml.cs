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

namespace WpfAppTextBox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtUserName.Text = "admin";
            txtPwd.Text = "admin";
        }

        private void txtPwd_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPwd.Text.Length < 6)
            {
                MessageBox.Show("密码长度不能小于6位");
                return;
            }
        }
    }
}
