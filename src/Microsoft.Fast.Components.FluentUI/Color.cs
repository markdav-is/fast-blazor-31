﻿using System;
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
              new Dictionary<Color, string>()
            {
                {Color.Highlight,"Highlight" },
                 {Color.Lowlight,"Lowlight" }
              };

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
             new Dictionary<Fill, string>()
            {
                {Fill.Highlight,"Highlight" },
                {Fill.Lowlight,"Lowlight" },

            };

        public static string ToAttributeValue(this Fill? value) => value == null ? null : _fillValues[value.Value];
    }
}
