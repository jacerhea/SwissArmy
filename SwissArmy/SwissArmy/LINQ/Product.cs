using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static int Product(this IEnumerable<int> source)
        {
            return source.Aggregate(1, (i, i1) => i*i1);
        }
    }
}
