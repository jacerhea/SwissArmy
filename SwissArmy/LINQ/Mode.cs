using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static int Mode(this IEnumerable<int> source)
        {
            return source.GroupBy(i => i).Select(g => Tuple.Create(g.Key, g.Count())).MaxBy(t => t.Item2).Item1;
        }
    }
}
