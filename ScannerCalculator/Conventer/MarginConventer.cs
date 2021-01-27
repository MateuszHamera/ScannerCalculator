using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ScannerCalculator.Conventer
{
    public class MarginConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Thickness(System.Convert.ToDouble(value) - 150, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
