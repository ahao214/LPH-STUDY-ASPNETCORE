using System.ComponentModel;
using System.Runtime.InteropServices;
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

namespace TemperatureDial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DefaultSet();

        }

        /// <summary>
        /// 按住鼠标左键拖动的事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }


        private int max;
        private int min;
        private int showValue;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Max
        {
            get { return max; }
            set
            {
                max = value;
                if (this.PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Max"));
            }
        }

        public int Min
        {
            get { return min; }
            set
            {
                min = value; if (this.PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Min"));
            }
        }

        public int ShowValue
        {
            get { return showValue; }
            set
            {
                showValue = value;
                if (this.PropertyChanged != null)
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("ShowValue"));
            }
        }


        private void DefaultSet()
        {
            max = 50;
            Min = -20;
            ShowValue = 15;
        }
    }
}