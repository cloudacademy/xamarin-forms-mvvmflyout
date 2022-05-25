using Xamarin.Forms;


namespace MVVMFlyout.Controls
{
    internal class FlyoutItemDynamicIcon: FlyoutItem
    {
        public static readonly BindableProperty IconGlyphProperty = BindableProperty.Create(nameof(IconGlyphProperty), 
                                                                    typeof(string), typeof(FlyoutItemDynamicIcon), string.Empty);
        public string IconGlyph
        {
            get { return (string)GetValue(IconGlyphProperty); }
            set { SetValue(IconGlyphProperty, value); }
        }
    }
}
