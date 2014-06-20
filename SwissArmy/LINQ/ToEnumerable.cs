using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> ToEnumerable<T>(this T item)
        {
            yield return item;
        }
    }
}