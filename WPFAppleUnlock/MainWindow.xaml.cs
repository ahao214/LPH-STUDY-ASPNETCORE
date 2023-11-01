using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFAppleUnlock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer _timer;
        private int[] passwds = new int[16];
        private string[] crilNames = new string[6];
        private int iseven = 0;
        private static int offset = 40;
        private int index = 0;



        public MainWindow()
        {
            InitializeComponent();

            // 定义动画对象
            DoubleAnimation daV = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(3)));
            // 设置动画过程需要改变属性的透明度
            this.Welcome_img.BeginAnimation(OpacityProperty, daV);
            // 创建定时器
            _timer = new Timer(3000);
            _timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            _timer.Start();


        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            this.Welcome_img.Dispatcher.Invoke(() =>
            {
                this.Welcome_img.Visibility = Visibility.Hidden;
            });
            this.lblTip.Dispatcher.Invoke(() =>
            {
                this.Welcome_img.Visibility = Visibility.Visible;
            });
            this.spInput.Dispatcher.Invoke(() =>
            {
                this.Welcome_img.Visibility = Visibility.Hidden;
            });
            this.spNumber.Dispatcher.Invoke(() =>
            {
                this.Welcome_img.Visibility = Visibility.Hidden;
            });  
            _timer.Stop();
        }

        /// <summary>
        /// 点击数字按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spNumber_Click(object sender,RoutedEventArgs e)
        {
            // 如何获取当前被点击按钮
            var button = (Button)e.OriginalSource;
            

        }

        /// <summary>
        /// 搜索制定名称的子元素
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static T FindClick<T>(DependencyObject obj,string name)where T : FrameworkElement
        {
            for(int i=0;i< VisualTreeHelper.GetChildrenCount(obj);i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if(child !=null && child is T &&(child as T)!.Name.Equals (name))
                {
                    return (T)child;
                }
                else
                {
                    T childOfChild = FindClick<T>(child!, name);
                    if(childOfChild!=null )
                    {
                        return childOfChild;
                    }
                }
            }
            return default;
        }
    }
}
