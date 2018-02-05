using System.Collections.Generic;

namespace SwissArmy.LINQ
{
    public static partial class LinqExtended
    {
        public static IEnumerable<TSource> StartAt<TSource>(this IEnumerable<TSource> source, TSource startAt)
        {
            var started = false;
            foreach (var item in source)
            {
                if (!started && item.Equals(startAt))
                {
                    started = true;
                }
                if (started)
                {
                    yield return item;
                }
            }
        } 
    }
}
