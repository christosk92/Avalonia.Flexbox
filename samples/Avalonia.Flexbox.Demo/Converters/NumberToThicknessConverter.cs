﻿using System;
using System.Globalization;

using Avalonia.Data.Converters;

namespace Avalonia.Flexbox.Demo.Converters
{
    internal sealed class NumberToThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int x && targetType.IsAssignableFrom(typeof(Thickness)))
            {
                var y = 16 + 2 * ((x * 5) % 9);
                return new Thickness(2 * y, y);
            }

            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotSupportedException();
    }
}
