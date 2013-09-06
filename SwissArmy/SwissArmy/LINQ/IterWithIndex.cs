
using System;
using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<Tuple<T, int>> IterWithIndex<T>(this IEnumerable<T> enumerable)
        {
            var i = 0;
            foreach (var obj in enumerable)
            {
                yield return new Tuple<T, int>(obj, i);
                i++;
            }
        }
    }
}