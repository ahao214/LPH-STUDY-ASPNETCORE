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
            this.LoadLight();
        }

        #region 定义灯的颜色

        static Color LowDefault = (Color)ColorConverter.ConvertFromString("#DEEBF7");
        static Color LowColor1 = (Color)ColorConverter.ConvertFromString("#00B0F0");
        static Color LowColor2 = (Color)ColorConverter.ConvertFromString("#0070C0");

        static Color MidDefault = (Color)ColorConverter.ConvertFromString("#FFF2CC");
        static Color MidColor1 = (Color)ColorConverter.ConvertFromString("#FFFF00");
        static Color MidColor2 = (Color)ColorConverter.ConvertFromString("#FFC000");

        static Color SuperDefault = (Color)ColorConverter.ConvertFromString("#FBE5D6");
        static Color SuperColor1 = (Color)ColorConverter.ConvertFromString("#FF0000");
        static Color SuperColor2 = (Color)ColorConverter.ConvertFromString("#C00000");


        #endregion


        static RotateTransform rotateTransform = new RotateTransform
        {
            CenterX = 12.5,
            CenterY = 12.5,
            Angle = 90
        };

        #region 定义画刷

        LinearGradientBrush LowDefaultLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(LowDefault,0.499),
                new GradientStop(LowDefault,0.5)
            }
        };

        LinearGradientBrush LowWarningLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(LowColor1,0.499),
                new GradientStop(LowColor2,0.5)
            }
        };

        LinearGradientBrush MidDefaultLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(MidDefault,0.499),
                new GradientStop(MidDefault,0.5)
            }
        };

        LinearGradientBrush MidWarningLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(MidColor1,0.499),
                new GradientStop(MidColor2,0.5)
            }
        };

        LinearGradientBrush SuperDefaultLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(SuperDefault,0.499),
                new GradientStop(SuperDefault,0.5)
            }
        };

        LinearGradientBrush SuperWarningLightBrush = new LinearGradientBrush
        {
            Transform = rotateTransform,
            GradientStops =
            {
                new GradientStop(SuperColor1,0.499),
                new GradientStop(SuperColor2,0.5)
            }
        };


        #endregion

        // 加载灯
        private void LoadLight()
        {
            this.LowLight.Fill = LowDefaultLightBrush;
            this.MidLight.Fill = MidDefaultLightBrush;
            this.SuperLight.Fill = SuperDefaultLightBrush;
        }

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
            this.DisplayNumber.Content = this.DisplayValue.ToString();
            if (DisplayValue < MinMark)
            {
                LowLight.Fill = LowWarningLightBrush;
                MidLight.Fill = MidDefaultLightBrush;
                SuperLight.Fill = SuperDefaultLightBrush;
            }
            else if (DisplayValue > MaxMark)
            {
                LowLight.Fill = LowDefaultLightBrush;
                MidLight.Fill = MidDefaultLightBrush;
                SuperLight.Fill = SuperWarningLightBrush;
            }
            else
            {
                LowLight.Fill = LowDefaultLightBrush;
                MidLight.Fill = MidWarningLightBrush;
                SuperLight.Fill = SuperDefaultLightBrush;
            }

        }

    }
}