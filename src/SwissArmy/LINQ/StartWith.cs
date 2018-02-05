using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<TSource> StartWhen<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> startWhen)
        {
            var started = false;
            foreach (var item in source)
            {
                if (!started && startWhen(item))
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
