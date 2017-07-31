﻿using System;
using System.Collections;
using System.Globalization;
using Xamarin.Forms;

namespace EmptyListTemplate
{
   public class DataSourceConverter : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         if (value == null)
            return true;

         return ((IList)value).Count == 0;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}
