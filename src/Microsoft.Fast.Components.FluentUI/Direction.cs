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
        //private static Dictionary<Direction, string> _directionValues =
        //    Enum.GetValues<Direction>().ToDictionary(id => id, id => Enum.GetName(id).ToLowerInvariant());

        /// <summary>
        /// making bacckwards compatible with netcore31 by hard coding
        /// </summary>
        private static Dictionary<Direction, string> _directionValues =
            new Dictionary<Direction, string>()
            {
                {Direction.Next,"Next" },
                {Direction.Previous,"Previous" }
            };

        public static string ToAttributeValue(this Direction? value) => value == null ? null : _directionValues[value.Value];
    }
}
