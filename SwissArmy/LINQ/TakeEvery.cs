using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
       public static IEnumerable<T> TakeEvery<T>(this IEnumerable<T> source, int nStep)
        {
            if (source == null) throw new ArgumentNullException("source");
            return source.Where((x, i) => i % nStep == 0);

        }
    }
}
