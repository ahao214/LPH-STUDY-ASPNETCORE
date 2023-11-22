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
    /// AddCargoWindow.xaml 的交互逻辑-添加物资
    /// </summary>
    public partial class AddCargoWindow : MetroWindow
    {
        public AddCargoWindow()
        {
            InitializeComponent();

            this.Loaded += ((s, e) =>
            {
                AppData.Instance.ShowMarkLayer(true);
                var vm = DataContext as AddCargoViewModel;
                vm.Cargo = new Models.Cargo();
            });

            this.Closing += ((s, e) =>
            {
                AppData.Instance.ShowMarkLayer(false);
            });

        }
    }
}
