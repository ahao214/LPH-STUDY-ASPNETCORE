using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfScrollBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Loaded += (s, e) =>
            {
                Maximum = element.ActualWidth - viewport.ActualWidth;
            };

        }

        private double maximum = 0;
        /// <summary>
        /// 滚动条的最大值
        /// </summary>
        public double Maximum
        {
            get { return maximum; }
            set { maximum = value; NotifyPropertyChanged("Maximum"); }
        }

        private double x = 0;
        /// <summary>
        /// 滚动条的当前值
        /// </summary>
        public double X
        {
            get { return x; }
            set { x = value; CanvasLeft = -x; NotifyPropertyChanged("X"); }
        }

        private double canvasLeft = 0;
        /// <summary>
        /// 相对于Canvas控件Left边距
        /// </summary>
        public double CanvasLeft
        {
            get { return canvasLeft; }
            set { canvasLeft = value; NotifyPropertyChanged("CanvasLeft"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 属性通知方法
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
