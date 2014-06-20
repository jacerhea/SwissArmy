using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<T> Wrap<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var iterationsSkipped = 0;
            var found = false;
            foreach (var item in source)
            {
                if (!found && predicate(item))
                {
                    found = true;
                }
                if (found)
                {
                    yield return item;
                }
                else
                {
                    iterationsSkipped = iterationsSkipped + 1;                    
                }
            }

            if (iterationsSkipped == 0)
            {
                yield break;
            }
            foreach (var item in source.Take(iterationsSkipped))
            {
                yield return item;
            }
        }
    }
}
