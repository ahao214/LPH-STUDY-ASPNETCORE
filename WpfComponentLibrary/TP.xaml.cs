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

namespace WpfComponentLibrary
{
    /// <summary>
    /// TP.xaml 的交互逻辑
    /// </summary>
    public partial class TP : UserControl
    {
        /// <summary>
        /// 最大温度
        /// </summary>
        public int Maximum
        {
            get { return (int)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Maximum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(int), typeof(TP), new PropertyMetadata(0));


        /// <summary>
        /// 最小温度
        /// </summary>
        public int Minimum
        {
            get { return (int)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Minimum.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(int), typeof(TP), new PropertyMetadata(0));





        public TP()
        {
            InitializeComponent();
            // 控件大小变化的时候触发
            this.SizeChanged += TP_SizeChanged;
        }

        private void TP_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RefreshComponent();
        }

        /// <summary>
        /// 核心初始化温度计刻度的方法
        /// </summary>
        private void RefreshComponent()
        {
            // 获取刻度板的真实高度
            var actualHeight = MainCanvas.ActualHeight;
            if (actualHeight == 0)
            {
                return;
            }
            double w = MainCanvas.Width;
            // 获取刻度盘的间隔数
            double stepCount = Maximum - Minimum;
            // 获取每一个间隔距离
            double step = actualHeight / stepCount;

            for (int i = 0; i <= stepCount; i++)
            {
                // 画直线
                Line line = new Line();
                line.Y1 = i * step;
                line.Y2 = i * step;

                line.Stroke = Brushes.Black;
                line.StrokeThickness = 1;
                MainCanvas.Children.Add(line);

                // 刻度线
                if (i % 10 == 0)
                {
                    line.X1 = 15;
                    line.X2 = w - 15;
                }
                else if (i % 5 == 0)
                {
                    line.X1 = 20;
                    line.X2 = w - 20;
                }
                else
                {
                    line.X1 = 25;
                    line.X2 = w - 25;
                }
            }


        }

    }
}
