﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum Autocomplete
    {
        Inline,
        List,
        Both
    }

    internal static class AutocompleteExtensions
    {
        private static Dictionary<Autocomplete, string> _autocompleteValues =
            EnumHelper.CreateEnumLowerValueDictionary<Autocomplete>();

        public static string ToAttributeValue(this Autocomplete? value) => value == null ? null : _autocompleteValues[value.Value];
    }

    public enum Position
    {
        Above,
        Below
    }

    internal static class PositionExtensions
    {
        private static Dictionary<Position, string> _positionValues =
             new Dictionary<Position, string>()
            {
                {Position.Above,"Above" },
                {Position.Below,"Below" },

            };

        public static string ToAttributeValue(this Position? value) => value == null ? null : _positionValues[value.Value];
    }
}
