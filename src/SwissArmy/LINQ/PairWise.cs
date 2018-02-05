using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<Tuple<TSource, TSource>> PairWise<TSource>(this IEnumerable<TSource> list)
        {
            var i = 0;
            TSource prior = default(TSource);
            foreach (var source in list)
            {
                if (i != 0)
                {
                    yield return new Tuple<TSource, TSource>(prior, source);
                }
                prior = source;
                i++;
            }
        }
    }
}
