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
using System.Xml.Schema;

namespace DialControlLibrary
{
    /// <summary>
    /// MercuryThermometer.xaml 的交互逻辑
    /// </summary>
    public partial class MercuryThermometer : UserControl
    {
        public MercuryThermometer()
        {
            InitializeComponent();
            TickMarkRepaint();
        }

        /// <summary>
        /// 温度计最大值
        /// </summary>
        public int Maximun
        {
            get { return (int)GetValue(MaximunProperty); }
            set { SetValue(MaximunProperty, value); }
        }

        public static readonly DependencyProperty MaximunProperty = DependencyProperty.Register("Maximun", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(50, new PropertyChangedCallback(ValueChanged)));



        /// <summary>
        /// 温度计最小值
        /// </summary>
        public int Minimun
        {
            get { return (int)GetValue(MinimunProperty); }
            set { SetValue(MinimunProperty, value); }
        }

        public static readonly DependencyProperty MinimunProperty =
            DependencyProperty.Register("Minimun", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(-20, new PropertyChangedCallback(ValueChanged)));


        /// <summary>
        /// 温度计显示数值
        /// </summary>
        public int DisplayValue
        {
            get { return (int)GetValue(DisplayValueProperty); }
            set { SetValue(DisplayValueProperty, value); }
        }

        public static readonly DependencyProperty DisplayValueProperty =
            DependencyProperty.Register("DisplayValue", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(0, new PropertyChangedCallback(ValueChanged)));


        private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as MercuryThermometer).TickMarkRepaint();
        }

        /// <summary>
        /// 重新绘制温度计
        /// </summary>
        private void TickMarkRepaint()
        {
            // 清空原有数据
            this.TickBorder.Children.Clear();

            double TickBorderHeight = 121;
            double RangeInterval = (Maximun - Minimun) / 2;
            double GraduationInterval = TickBorderHeight / RangeInterval;

            // 绘制刻度
            for (int i = 0; i <= RangeInterval; i++)
            {
                Line line = new Line();
                line.X1 = 2;
                line.Y1 = i * GraduationInterval;
                line.X2 = 10;
                line.Y2 = i * GraduationInterval;
                Color lineColor = (Color)ColorConverter.ConvertFromString("#BCA258");
                Brush lineBrush = new SolidColorBrush(lineColor);
                line.Stroke = lineBrush;
                line.StrokeThickness = 1;

                this.TickBorder.Children.Add(line);

                if(i %2.5!=0)
                {
                    line.X2 = 4.5;
                }
                else
                {
                    // 刻度值是10的倍数
                    TextBlock textBlock = new TextBlock
                    {
                        FontSize = 9,
                        Width = 20,
                        FontFamily = new FontFamily("Arial"),
                        Foreground = lineBrush,
                        TextAlignment = TextAlignment.Right,
                        Text = (Maximun - i * 2).ToString(),
                        Margin = new Thickness(10, -5 + i * GraduationInterval, 0, 0)
                    };
                    this.TickBorder.Children.Add(textBlock);
                }

            }


        }

    }
}
