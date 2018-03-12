using System;

namespace BoundedContext.NucleoCompartilhado.Domain.Model
{
    public static class EnumConversion
    {
        public static T ToEnum<T>(this string value) => (T)Enum.Parse(typeof(T), value);
        public static T ToEnum<T>(this int value) => (T)Enum.ToObject(typeof(T), value);
    }
}
