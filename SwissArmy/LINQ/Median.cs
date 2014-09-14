using System;
using System.Collections.Generic;
using System.Linq;
using SwissArmy.Extensions;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static double Median(this IEnumerable<int> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            var list = source.OrderBy(i => i).ToList();
            var count = list.Count;
            if (count == 0)
            {
                return default(int);
            }
            else if (count.IsEven())
            {
                var midpoint = (int)Math.Floor(count / 2D) - 1;
                return (list[midpoint] + list[(midpoint + 1)]) / (double)2;
            }
            else
            {
                return list[(int)Math.Floor(count / 2D)];
            }
        }
    }
}
