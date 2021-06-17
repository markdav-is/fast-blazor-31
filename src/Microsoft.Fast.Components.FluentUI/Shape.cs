using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Shape
    {
        Rect,
        Circle
    }

    internal static class ShapeExtensions
    {
        private static Dictionary<Shape, string> _orientationValues =
            EnumHelper.CreateEnumLowerValueDictionary<Shape>();

        public static string ToAttributeValue(this Shape? value) => value == null ? null : _orientationValues[value.Value];
    }
}
