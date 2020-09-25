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
    /// RadioButton コンバーター
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {
        // enum(source)  -> bool(target)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // パラメータを文字列に変換
            var parameterString = parameter as string;
            if (null == parameterString)
                return DependencyProperty.UnsetValue;

            if (!Enum.IsDefined(value.GetType(), value))
                return DependencyProperty.UnsetValue;

            var parameterValue = Enum.Parse(value.GetType(), parameterString);
            return parameterValue.Equals(value);
        }

        // bool(target) -> enum(source) 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterString = parameter as string;
            if (null == parameterString)
                return DependencyProperty.UnsetValue;

            if (true.Equals(value))
                return Enum.Parse(targetType, parameterString);
            else
                return DependencyProperty.UnsetValue;
        }
    }
}
