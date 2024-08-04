using System.Collections.Generic;
using System.Linq;

namespace MyApp.WPF.Converters
{
    internal static class LocalEx
    {
        public static double ExtractDouble(this object value)
        {
            double d = value as double? ?? double.NaN;
            return double.IsInfinity(d) ? double.NaN : d;
        }


        public static bool AnyNan(this IEnumerable<double> values) => values.Any(double.IsNaN);
    }
}
