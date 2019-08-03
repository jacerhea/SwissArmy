using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static T Mode<T>(this IEnumerable<T> source) where T : IComparable
        {
            return source.GroupBy(i => i).Select(g => Tuple.Create(g.Key, g.Count())).MaxBy(t => t.Item2).Item1;
        }
    }
}
