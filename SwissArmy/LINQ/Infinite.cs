using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<TSource> Infinite<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            while (true)
            {
                foreach (var item in source)
                {
                    yield return item;
                }
            }
        }
    }
}
