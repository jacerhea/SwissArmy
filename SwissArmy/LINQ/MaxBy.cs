using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static TSource MaxBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> selector) where TKey : IComparable
        {
            var max = default(TSource);
            var maxKey = default(TKey);
            var comparer = Comparer<TKey>.Default;
            foreach (var s in source)
            {
                var key = selector(s);
                if (comparer.Compare(key, maxKey) > 0)
                {
                    max = s;
                    maxKey = key;
                }
            }

            return max;
        }
    }
}
