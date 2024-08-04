using System;
using System.Windows;
using System.Globalization;
using System.Windows.Data;

namespace MyApp.WPF.Converters
{
    public class StartPointConverter : IValueConverter
    {
        [Obsolete]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double v && (v > 0.0))
            {
                return new Point(v / 2, 0);
            }

            return new Point();
        }

        [Obsolete]
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => Binding.DoNothing;

    }
}
