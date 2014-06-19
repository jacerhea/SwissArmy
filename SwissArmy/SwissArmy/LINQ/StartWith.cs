using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<TSource> StartWhen<TSource, T1>(this IEnumerable<TSource> source, Func<T1, bool> startWhen)
        {
            var started = false;
            foreach (var item in source)
            {
                if (!started && item.Equals(startAt))
                {
                    started = true;
                }
                if (started)
                {
                    yield return item;
                }
            }
        } 
    }
}
