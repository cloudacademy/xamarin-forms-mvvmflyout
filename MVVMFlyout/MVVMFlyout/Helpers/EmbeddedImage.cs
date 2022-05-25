using System;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMFlyout.Helpers
{
    [ContentProperty(nameof(Source))]
    public class EmbeddedImage : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrEmpty(Source))
                return null;
            return ImageSource.FromResource(Source, typeof(EmbeddedImage).GetTypeInfo().Assembly);
        }
    }

    public class StringToImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource(value as string, typeof(StringToImageSourceConverter).GetTypeInfo().Assembly);
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

    }
}
