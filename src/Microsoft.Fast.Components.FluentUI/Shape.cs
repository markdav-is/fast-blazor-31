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
            new Dictionary<Shape, string>()
            {
                {Shape.Rect,"Rect" },
                {Shape.Circle,"Circle" },
               
            };

        public static string ToAttributeValue(this Shape? value) => value == null ? null : _orientationValues[value.Value];
    }
}
