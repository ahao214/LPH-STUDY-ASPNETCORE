using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestUriExternal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            img.Source = new BitmapImage(new Uri("pack://application:,,,/External;component/images/JD.jpg", UriKind.RelativeOrAbsolute));


            img.Source = new BitmapImage(new Uri("/External;component/images/JD.jpg", UriKind.RelativeOrAbsolute));



        }
    }
}