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

namespace WpfBaseControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRad_Click(object sender, RoutedEventArgs e)
        {
            string order = string.Empty;
            if(rad1.IsChecked .Value )
            {
                order += rad1.Content+",";
            }
            if(rad2.IsChecked .Value )
            {
                order += rad2.Content + ",";
            }
            if(rad3.IsChecked .Value )
            {
                order += rad3.Content + ",";
            }
            MessageBox.Show($"菜单是{order}");
        }
    }
}
