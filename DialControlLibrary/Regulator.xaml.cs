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
    /// Regulator.xaml 的交互逻辑
    /// </summary>
    public partial class Regulator : UserControl
    {
        public Regulator()
        {
            InitializeComponent();
        }




        public int MaxInput
        {
            get { return (int)GetValue(MaxInputProperty); }
            set { SetValue(MaxInputProperty, value); }
        }

        public static readonly DependencyProperty MaxInputProperty =
            DependencyProperty.Register("MaxInput", typeof(int), typeof(Regulator), new PropertyMetadata(0));




        public int MinInput
        {
            get { return (int)GetValue(MinInputProperty); }
            set { SetValue(MinInputProperty, value); }
        }

        public static readonly DependencyProperty MinInputProperty =
            DependencyProperty.Register("MinInput", typeof(int), typeof(Regulator), new PropertyMetadata(0));



        public int NumOutPut
        {
            get { return (int)GetValue(NumOutPutProperty); }
            set { SetValue(NumOutPutProperty, value); }
        }

        public static readonly DependencyProperty NumOutPutProperty =
            DependencyProperty.Register("ValueInput", typeof(int), typeof(Regulator), new PropertyMetadata(0));









    }
}
