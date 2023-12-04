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

namespace DialControlLibrary
{
    /// <summary>
    /// Indicator.xaml 的交互逻辑
    /// </summary>
    public partial class Indicator : UserControl
    {
        public Indicator()
        {
            InitializeComponent();
        }

        #region 定义灯的颜色

        static Color LowDefault = (Color)ColorConverter.ConvertFromString("#DEEBF7");
        static Color LowColor1 = (Color)ColorConverter.ConvertFromString("#00B0F0");
        static Color LowColor2 = (Color)ColorConverter.ConvertFromString("#0070C0");

        static Color MinDefault = (Color)ColorConverter.ConvertFromString("#FFF2CC");
        static Color MidColor1 = (Color)ColorConverter.ConvertFromString("#FFFF00");
        static Color MidColor2 = (Color)ColorConverter.ConvertFromString("#FFC000");

        static Color SuperDefault = (Color)ColorConverter.ConvertFromString("#FBE5D6");
        static Color SuperColor1 = (Color)ColorConverter.ConvertFromString("#FF0000");
        static Color SuperColor2 = (Color)ColorConverter.ConvertFromString("#C00000");


        #endregion

        public int MaxMark
        {
            get { return (int)GetValue(MaxMarkProperty); }
            set { SetValue(MaxMarkProperty, value); }
        }


        public static readonly DependencyProperty MaxMarkProperty =
            DependencyProperty.Register("MaxMark", typeof(int), typeof(Indicator), new PropertyMetadata(50, new PropertyChangedCallback(ValueChanged)));

        public int MinMark
        {
            get { return (int)GetValue(MinMarkProperty); }
            set { SetValue(MinMarkProperty, value); }
        }


        public static readonly DependencyProperty MinMarkProperty =
            DependencyProperty.Register("MinMark", typeof(int), typeof(Indicator), new PropertyMetadata(-20, new PropertyChangedCallback(ValueChanged)));


        public int DisplayValue
        {
            get { return (int)GetValue(DisplayValueProperty); }
            set { SetValue(DisplayValueProperty, value); }
        }


        public static readonly DependencyProperty DisplayValueProperty =
            DependencyProperty.Register("DisplayValue", typeof(int), typeof(Indicator), new PropertyMetadata(0, new PropertyChangedCallback(ValueChanged)));


        private static void ValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((Indicator)d).LightContorl();

        }

        /// <summary>
        /// 控制灯
        /// </summary>
        private void LightContorl()
        {

        }

    }
}
