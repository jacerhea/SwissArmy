using System;

namespace SwissArmy.Reflection
{
    public static class TypeExtensions
    {
        public static bool IsNullableType(this Type t)
        {
            return t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
