using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Orientation
    {
        Vertical
    }

    internal static class OrientationExtensions
    {
        private static Dictionary<Orientation, string> _orientationValues =
            EnumHelper.CreateEnumLowerValueDictionary<Orientation>();

        public static string ToAttributeValue(this Orientation? value) => value == null ? null : _orientationValues[value.Value];
    }
}
