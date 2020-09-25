using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace TEST_GitHub.Mvvm
{
    /// <summary>
    /// Int Boolean コンバーター
    /// </summary>
    [ValueConversion(typeof(int), typeof(bool))]
    public class IntToBooleanConverter : IValueConverter
    {
        // int(source) -> bool(target)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterString = parameter as string;
            if (null == parameterString)
                return DependencyProperty.UnsetValue;

            if (!int.TryParse(parameterString, out int parameterValue))
                return DependencyProperty.UnsetValue;

            return parameterValue.Equals(value);
        }

        // bool(target) -> int(source) 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterString = parameter as string;
            if (null == parameterString)
                return DependencyProperty.UnsetValue;

            if (true.Equals(value))
                return int.Parse(parameterString);
            else
                return DependencyProperty.UnsetValue;
        }
    }
}
