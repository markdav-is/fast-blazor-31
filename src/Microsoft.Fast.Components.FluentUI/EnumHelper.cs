using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Fast.Components.FluentUI
{
    class EnumHelper
    {
        public static Dictionary<TEnum, string> CreateEnumLowerValueDictionary<TEnum>() where TEnum : Enum
        {
            var d = new Dictionary<TEnum, string>();
            foreach (var key in Enum.GetValues(typeof(TEnum)))
            {
                d[(TEnum)key] = key.ToString().ToLowerInvariant();
            }
            return d;
        }
    }
}
