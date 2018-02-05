using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> Append<T>(this IEnumerable<T> list, T item)
        {
            foreach (var selectListItem in list)
            {
                yield return selectListItem;
            }
            yield return item;
        }
    }
}
