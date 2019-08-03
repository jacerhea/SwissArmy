using System;
using System.Reflection;

namespace SwissArmy.Reflection
{
    public static class TypeExtensions
    {
        public static bool IsNullableType(this Type t)
        {
            return t.GetTypeInfo().IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
