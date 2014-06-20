using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public  static partial class LinqExtended
    {
        public static bool Empty<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            var iterator = source.GetEnumerator();
            return !iterator.MoveNext();
        }

        public static bool Empty<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException("source");
            return  !source.Any(predicate);
        }
    }
}
