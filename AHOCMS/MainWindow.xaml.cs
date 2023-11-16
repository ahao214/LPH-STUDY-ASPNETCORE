using AHOCMS.View;
using MahApps.Metro.Controls;
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

namespace AHOCMS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!(sender is RadioButton button))
            {
                return;
            }
            if (string.IsNullOrEmpty(button.Content.ToString()))
            {
                return;
            }
            switch (button.Content.ToString())
            {
                case "首页":
                    container.Content = new IndexView();
                    break;
                case "出入库":
                    container.Content = new RecordView();
                    break;
                case "物资管理":
                    container.Content = new CargoView();
                    break;
                case "用户管理":
                    container.Content = new MemberView();
                    break;
                case "类型设置":
                    container.Content = new CargoTypeView();
                    break;
                default:
                    break;
            }
        }
    }
}
