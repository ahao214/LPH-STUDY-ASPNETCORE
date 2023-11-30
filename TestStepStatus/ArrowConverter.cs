using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;


namespace TestStepStatus
{
    /// <summary>
    /// 剪头转换器
    /// </summary>
    public class ArrowConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return null;
            }
            int step = int.Parse(value.ToString());
            int imgStep = int.Parse(parameter.ToString());
            BitmapImage bitmap;
            if (step < imgStep)
            {                
                string path = @"pack://application:,,,/TestStepStatus:component/Images/1.png";
                bitmap = new BitmapImage(new Uri(path, UriKind.Absolute));
                return bitmap;
            }
            else
            {                
                string path = @"pack://application:,,,/TestStepStatus:component/Images/2.png";
                bitmap = new BitmapImage(new Uri(path, UriKind.Absolute));
                return bitmap;
            }



        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
