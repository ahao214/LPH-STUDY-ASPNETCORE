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



        public int MaxMark
        {
            get { return (int)GetValue(MaxMarkProperty); }
            set { SetValue(MaxMarkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxMarkProperty =
            DependencyProperty.Register("MaxMark", typeof(int), typeof(Indicator), new PropertyMetadata(50, new PropertyChangedCallback(ValueChanged)));



        public int MinMark
        {
            get { return (int)GetValue(MinMarkProperty); }
            set { SetValue(MinMarkProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinMark.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinMarkProperty =
            DependencyProperty.Register("MinMark", typeof(int), typeof(Indicator), new PropertyMetadata(-20, new PropertyChangedCallback(ValueChanged)));





        public int DisplayValue
        {
            get { return (int)GetValue(DisplayValueProperty); }
            set { SetValue(DisplayValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayValue.  This enables animation, styling, binding, etc...
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
