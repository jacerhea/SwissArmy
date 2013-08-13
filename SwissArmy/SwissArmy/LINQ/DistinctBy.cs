using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> DistinctBy<T>(this IEnumerable<T> thisEnumerable, Func<T, T> keySelector)
        {
            return thisEnumerable.GroupBy(keySelector).Select(g => g.First());
        }
    }
}
