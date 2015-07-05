using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static ConcurrentBag<T> ToConcurrentBag<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return new ConcurrentBag<T>(source);
        }
    }
}
