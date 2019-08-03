using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SwissArmy
{
    public static class EnumHelper
    {

        /// <summary>
        /// Converts string to enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="s">convertible string</param>
        /// <returns>Enum</returns>
        public static T ToEnum<T>(this string s) where T : struct, IConvertible
        {
            if (!typeof(T).GetTypeInfo().IsEnum) { throw new ArgumentException("T must be an enumerated type"); }
            return (T)Enum.Parse(typeof(T), s, true);
        }

        /// <summary>
        /// Gets an attribute on an enum field value
        /// </summary>
        /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
        /// <param name="enumVal">The enum value</param>
        /// <returns>The attribute of type T that exists on the enum value</returns>
        //public static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        //{
        //    var type = enumVal.GetType();
        //    var memInfo = type.GetRuntimeMethod((enumVal.ToString());
        //    var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
        //    return (T)attributes[0];
        //}

        public static IEnumerable<T> GetValues<T>() where T : struct, IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
