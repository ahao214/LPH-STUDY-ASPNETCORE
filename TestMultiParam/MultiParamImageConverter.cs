using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TestMultiParam
{
    public class MultiParamImageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null)
                return null;
            int age = int.Parse(values[0].ToString());
            int grade = int.Parse(values[1].ToString());
            BitmapImage bitmap;
            if(age > 14 && grade > 8)
            {
                string path = @"pack://application:,,,/TestMultiParam:component/Images/Osx44.ico";
                bitmap = new BitmapImage(new Uri(path,UriKind.Absolute));
                return bitmap;
            }
            else
            {
                string path = @"pack://application:,,,/TestMultiParam:component/Images/Osx45.ico";
                bitmap = new BitmapImage(new Uri(path, UriKind.Absolute));
                return bitmap;
            }


        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
