using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVMFlyout.Helpers
{

    public class FocusIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string imagePath = string.Format("{0}_{1}.png", value, parameter.ToString());
            return imagePath;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.Format("Hello {0}", value);
        }
    }
}
