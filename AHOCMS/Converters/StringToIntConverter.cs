﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace AHOCMS.Converters
{
    public class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "管理员";

            if (int.TryParse(value.ToString(), out int role))
            {
                switch (role)
                {
                    case 0:
                        return "管理员";
                    case 1:
                        return "操作员";
                    default: break;
                }
            }

            return "操作员";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int result = 0;
            if (value == null)
                return result;
            switch (value.ToString())
            {
                case "管理员":
                    result = 0;
                    break;
                case "操作员":
                    result = 1;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
