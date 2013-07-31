using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static class LinqExtended
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException("source");
            return new HashSet<T>(source);
        }

        public static IEnumerable<Tuple<T, int>> IterWithIndex<T>(this IEnumerable<T> enumerable)
        {
            var i = 0;
            foreach (var obj in enumerable)
            {
                yield return new Tuple<T, int>(obj, i);
                i++;
            }
        }

        public static IEnumerable<T> ToEnumerable<T>(this T item)
        {
            yield return item;
        }

        public static IEnumerable<T> OrderBy<T>(this IEnumerable<T> list, T item)
        {
            yield return item;
            foreach (var selectListItem in list)
            {
                yield return selectListItem;
            }
        }

        public static IEnumerable<T> Prepend<T>(this IEnumerable<T> list, T item)
        {
            yield return item;
            foreach (var selectListItem in list)
            {
                yield return selectListItem;
            }
        }

        public static IEnumerable<IEnumerable<T>> GroupList<T>(this IEnumerable<T> thisEnumerable, int sizeOfGroup)
        {
            return thisEnumerable
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / sizeOfGroup)
                .Select(x => x.Select(v => v.Value));
        }

        public static string ToCSV(this IEnumerable<string> collection)
        {
            return String.Join(",", collection.ToArray());
        }
    }
}
