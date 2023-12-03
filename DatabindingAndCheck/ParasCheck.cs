using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DatabindingAndCheck
{
    /// <summary>
    /// 数据校验
    /// </summary>
    public class ParasCheck : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double num;
            if (double.TryParse(value.ToString(), out num))
            {
                if (num == 0)
                {
                    return new ValidationResult(false, "除数不能为零");
                }
            }
            return ValidationResult.ValidResult;

        }

    }
}
