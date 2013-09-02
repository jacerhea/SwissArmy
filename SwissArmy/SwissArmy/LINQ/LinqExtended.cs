using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<Tuple<T, int>> IterWithIndex<T>(this IEnumerable<T> enumerable)
        {
            var i = 0;
            foreach (var obj in enumerable)
            {
                yield return new Tuple<T, int>(obj, i);
                i++;
            }
        }

        public static IEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> list, Func<TSource,TKey> keySelector, ListSortDirection sort)
        {
            if (sort == ListSortDirection.Ascending)
            {
                return list.OrderBy(keySelector);
            }
            return list.OrderByDescending(keySelector);
        }


        public static IEnumerable<Tuple<TSource, TSource>> PairWise<TSource>(this IEnumerable<TSource> list)
        {
            var i = 0;
            TSource prior = default(TSource);
            foreach (var source in list)
            {
                if (i != 0)
                {
                    yield return new Tuple<TSource, TSource>(prior, source);
                }
                prior = source;
            }
        }

 


        public static IEnumerable<IEnumerable<T>> GroupList<T>(this IEnumerable<T> thisEnumerable, int sizeOfGroup)
        {
            return thisEnumerable
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / sizeOfGroup)
                .Select(x => x.Select(v => v.Value));
        }
    }
}