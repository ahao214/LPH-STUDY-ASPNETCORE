﻿using System;
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
using System.Windows.Shapes;

namespace WpfAppBase
{
    /// <summary>
    /// WrapPanelWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Content = "座位" + (i + 1).ToString("00") + "号";
                cb.Foreground = new SolidColorBrush(Colors.Red);
                cb.Margin = new Thickness(3, 2, 3, 2);
                wp01.Children.Add(cb);


            }
        }
    }
}
