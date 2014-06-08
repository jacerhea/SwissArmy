using System;
using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<TResult> Cartesian<TFirst, TSecond, TResult>(this IEnumerable<TFirst> source1, IEnumerable<TSecond> source2, Func<TFirst, TSecond, TResult> resultSelector)
        {
            if (source1 == null) throw new ArgumentNullException("source1");
            if (source2 == null) throw new ArgumentNullException("source2");
            if (resultSelector == null) throw new ArgumentNullException("resultSelector");

            var bufferedSecond = new Lazy<List<TSecond>>(source2.ToList);
            return source1.SelectMany(item1 => bufferedSecond.Value.Select(item2 => resultSelector(item1, item2)));
        }
    }
}
