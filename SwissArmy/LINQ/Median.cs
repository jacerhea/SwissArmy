using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static int Median(this IEnumerable<int> source)
        {
            var list = source.ToList();
            return list[list.Count/2];
        }
    }
}
