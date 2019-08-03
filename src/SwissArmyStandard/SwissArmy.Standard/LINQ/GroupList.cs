using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<IEnumerable<T>> GroupList<T>(this IEnumerable<T> thisEnumerable, int sizeOfGroup)
        {
            return thisEnumerable
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / sizeOfGroup)
                .Select(x => x.Select(v => v.Value));
        }
    }
}
