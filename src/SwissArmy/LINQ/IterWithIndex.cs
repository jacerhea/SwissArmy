using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<Tuple<T, int>> IterWithIndex<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Select((arg1, i) => Tuple.Create(arg1, 1));
        }
    }
}