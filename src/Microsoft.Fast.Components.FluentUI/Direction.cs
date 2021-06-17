using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Direction
    {
        Previous,
        Next
    }

    internal static class DirectionExtensions
    {
        
        private static Dictionary<Direction, string> _directionValues =
            EnumHelper.CreateEnumLowerValueDictionary<Direction>();

        public static string ToAttributeValue(this Direction? value) => value == null ? null : _directionValues[value.Value];
    }
}
