using DataBoard.Views;
using GalaSoft.MvvmLight.Ioc;
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

namespace DataBoard
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += (x, y) =>
            {
                container.Content = SimpleIoc.Default.GetInstance<IndexView>();
            };
        }

        #region 页面导航

        /// <summary>
        /// 页面导航
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(!(sender is RadioButton radioButton)) return;
            var uid = radioButton.Uid;
            if(string.IsNullOrEmpty (uid) )
            {
                return;
            }
            switch (uid)
            {
                case "IndexView":
                    container .Content = SimpleIoc .Default .GetInstance<IndexView>();
                    break;
                case "HistoryView":
                    container.Content = SimpleIoc.Default.GetInstance<HistoryView>();
                    break;
                case "LineView":
                    container.Content = SimpleIoc.Default.GetInstance<LineView>();
                    break;
                case "SubLineView":
                    container.Content = SimpleIoc.Default.GetInstance<SubLineView>();
                    break;
                case "StopTypeView":
                    container.Content = SimpleIoc.Default.GetInstance<StopTypeView>();
                    break;
                case "UserInfoView":
                    container.Content = SimpleIoc.Default.GetInstance<UserInfoView>();
                    break;
              
                default:break;
            }

        
        
        }

        #endregion
    }
}
