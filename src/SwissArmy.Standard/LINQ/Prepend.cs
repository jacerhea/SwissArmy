using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> list, T item)
        {
            yield return item;
            foreach (var selectListItem in list)
            {
                yield return selectListItem;
            }
        }

        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> list, IEnumerable<T> list2)
        {
            return list2.Concat(list);
        }
    }
}
