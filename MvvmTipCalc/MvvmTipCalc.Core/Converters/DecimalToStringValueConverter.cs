using System;
using System.Globalization;
using MvvmCross.Platform.Converters;

namespace MvvmTipCalc.Core.Converters
{
   public class DecimalToStringValueConverter : IMvxValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         var val = (decimal)value;
         if (val == 0) return "";
         return val.ToString();
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         decimal retVal;
         decimal.TryParse((string)value, out retVal);
         return retVal;
      }
   }
}
