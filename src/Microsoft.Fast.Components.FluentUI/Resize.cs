using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Resize
    {
        Horizontal,
        Vertical,
        Both
    }

    internal static class ResizeExtensions
    {
        private static Dictionary<Resize, string> _resizeValues =
            new Dictionary<Resize, string>()
            {
                {Resize.Horizontal,"Horizontal" },
                {Resize.Vertical,"Vertical" },
                {Resize.Both,"Both" }
            };

        public static string ToAttributeValue(this Resize? value) => value == null ? null : _resizeValues[value.Value];
    }
}
