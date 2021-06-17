using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Color
    {
        Highlight,
        Lowlight
    }

    internal static class ColorExtensions
    {
        private static Dictionary<Color, string> _colorValues =
            EnumHelper.CreateEnumLowerValueDictionary<Color>();

        public static string ToAttributeValue(this Color? value) => value == null ? null : _colorValues[value.Value];
    }

    public enum Fill
    {
        Highlight,
        Lowlight
    }

    internal static class FillExtensions
    {
        private static Dictionary<Fill, string> _fillValues =
            EnumHelper.CreateEnumLowerValueDictionary<Fill>();

        public static string ToAttributeValue(this Fill? value) => value == null ? null : _fillValues[value.Value];
    }
}
