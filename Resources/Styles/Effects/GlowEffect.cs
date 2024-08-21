using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace paletteflow.Resources.Styles.Effects
{
    public static class GlowEffect
    {
        public static readonly DependencyProperty GlowColorProperty =
            DependencyProperty.RegisterAttached(
                "GlowColor",
                typeof(Color),
                typeof(GlowEffect),
                new PropertyMetadata(Colors.Transparent));

        public static Color GetGlowColor(DependencyObject obj)
        {
            return (Color)obj.GetValue(GlowColorProperty);
        }

        public static void SetGlowColor(DependencyObject obj, Color value)
        {
            obj.SetValue(GlowColorProperty, value);
        }
    }
}
