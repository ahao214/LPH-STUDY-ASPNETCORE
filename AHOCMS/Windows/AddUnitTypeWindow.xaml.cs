using AHOCMS.ViewModel;
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
using System.Windows.Shapes;

namespace AHOCMS.Windows
{
    /// <summary>
    /// AddUnitTypeWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddUnitTypeWindow : MetroWindow
    {
        public AddUnitTypeWindow()
        {
            InitializeComponent();
            this.Loaded += ((s, e) =>
            {
                AppData.Instance.ShowMarkLayer(true);
                // 清空文本框的值
                var vm = DataContext as AddUnitTypeViewModel;
                vm.UnitType = new Models.UnitType();
            });
            this.Closing += ((s, e) =>
            {
                AppData.Instance.ShowMarkLayer(false);
            });
        }
    }
}
