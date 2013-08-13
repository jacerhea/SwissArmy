using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static string ToCSV(this IEnumerable<string> collection)
        {
            if (collection == null) throw new ArgumentNullException("collection");
            return String.Join(",", collection.ToArray());
        }
    }
}