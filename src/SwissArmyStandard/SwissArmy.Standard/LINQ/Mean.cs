using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static double Mean(this IEnumerable<int> source)
        {
            var x = source.Aggregate(Tuple.Create(0, default(int)), (arg1, arg2) => Tuple.Create(arg1.Item1 + 1, arg1.Item2 + arg2));
            if (x.Item1 == 0)
            {
                return 0;
            }
            return x.Item2/(double)x.Item1;
        }
    }
}
