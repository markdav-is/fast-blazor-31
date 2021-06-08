using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Appearance
    {
        Neutral,
        Accent,
        Hypertext,
        Lightweight,
        Outline,
        Stealth,
        Filled
    }

    internal static class AppearanceExtensions
    {
        private static Dictionary<Appearance, string> _appearanceValues =
              new Dictionary<Appearance, string>()
            {
                {Appearance.Neutral,"Neutral" },
                {Appearance.Accent,"Accent" },
                {Appearance.Hypertext,"Hypertext" },
                {Appearance.Lightweight,"Lightweight" },
                {Appearance.Outline,"Outline" },
                {Appearance.Stealth,"Stealth" },
                {Appearance.Filled,"Filled" },

            };

        public static string ToAttributeValue(this Appearance? value) => value == null ? null : _appearanceValues[value.Value];
    }
}
