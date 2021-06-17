﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Fast.Components.FluentUI
{
    public enum ExpandMode
    {
        Single
    }

    internal static class ExpandModeExtensions
    {
       

        private static Dictionary<ExpandMode, string> _expandModeValues =
            EnumHelper.CreateEnumLowerValueDictionary<ExpandMode>();

        public static string ToAttributeValue(this ExpandMode? value) => value == null ? null : _expandModeValues[value.Value];
    }
}
