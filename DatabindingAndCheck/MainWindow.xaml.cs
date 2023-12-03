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

namespace DatabindingAndCheck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee = new Employee() { Name = "Default name" };




        public MainWindow()
        {
            InitializeComponent();
        }

        private void OutputName_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}