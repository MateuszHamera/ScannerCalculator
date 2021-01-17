using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ScannerCalculator.Conventer
{
    public class InverseValueConventer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int min = 150;
            int max = 600;
            int v = ((int)value-min) * 100;
            double difference = max - min;
            double a = difference / 100;
            double percent = (double)v / difference;
            double result = -a*percent + 600;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
