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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.SourceInitialized += (s, e) => Console.WriteLine("MainWindow.SourceInitialized 被触发");

            this.Activated += (s, e) => Console.WriteLine("2.MainWindow.Activated 被触发");

            this.Loaded += (s, e) => Console.WriteLine("3.MainWindow.Loaded 被触发");

            this.ContentRendered += (s, e) => Console.WriteLine("4.MainWindow.ContentRendered 被触发");

            this.Deactivated += (s, e) => Console.WriteLine("5.MainWindow.Deactivated 被触发");

            this.Closing += (s, e) => Console.WriteLine("6.MainWindow.Closing 被触发");

            this.Closed += (s, e) => Console.WriteLine("6.MainWindow.Closed 被触发");

            this.Unloaded += (s, e) => Console.WriteLine("6.MainWindow.Unloaded 被触发");

        }
    }
}
