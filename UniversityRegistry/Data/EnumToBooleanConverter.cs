using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Globalization;

namespace UniversityRegistry.Data
{
    /// <summary>
    /// A class for converting enum values to booleans for use in data binding
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {

        /// <summary>
        /// Converts an enum value into a boolean by comparing it to the supplied parameter.  
        /// If the value and parameter are the same, the method returns true; otherwise false
        /// </summary>
        /// <param name="value">The enum value to convert</param>
        /// <param name="targetType">The type to convert to (should be a boolean)</param>
        /// <param name="param">The enum value to compare to</param>
        /// <param name="culture">The culture info</param>
        /// <returns>True if the enum matches the param, false otherwise</returns>
        public object Convert(object value, Type targetType, object param, CultureInfo culture)
        {
            return value.Equals(param);
        }

        /// <summary>
        /// Converts a boolean into an enum value.  If the boolean is true, the parameter is returned,
        /// otherwise DependencyProperty.UnsetValue is returned (which unsets the control)
        /// </summary>
        /// <param name="value">The boolean to convert</param>
        /// <param name="targetType">The type to convert (should be an enum)</param>
        /// <param name="param">The enumeration value to check</param>
        /// <param name="culture">The culture info</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object param, CultureInfo culture)
        {
            if ((bool)value) return param;
            else return DependencyProperty.UnsetValue;
        }
    }
}
