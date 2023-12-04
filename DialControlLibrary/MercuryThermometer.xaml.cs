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
    /// MercuryThermometer.xaml 的交互逻辑
    /// </summary>
    public partial class MercuryThermometer : UserControl
    {
        public MercuryThermometer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 温度计最大值
        /// </summary>
        public int Maximun
        {
            get { return (int)GetValue(MaximunProperty); }
            set { SetValue(MaximunProperty, value); }
        }

        public static readonly DependencyProperty MaximunProperty = DependencyProperty.Register("Maximun", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(50));



        /// <summary>
        /// 温度计最小值
        /// </summary>
        public int Minimun
        {
            get { return (int)GetValue(MinimunProperty); }
            set { SetValue(MinimunProperty, value); }
        }

        public static readonly DependencyProperty MinimunProperty =
            DependencyProperty.Register("Minimun", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(-20));


        /// <summary>
        /// 温度计显示数值
        /// </summary>
        public int DisplayValue
        {
            get { return (int)GetValue(DisplayValueProperty); }
            set { SetValue(DisplayValueProperty, value); }
        }

        public static readonly DependencyProperty DisplayValueProperty =
            DependencyProperty.Register("DisplayValue", typeof(int), typeof(MercuryThermometer), new PropertyMetadata(0));




    }
}
