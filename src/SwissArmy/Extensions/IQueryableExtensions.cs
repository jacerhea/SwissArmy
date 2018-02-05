using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.Standard.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> IsBetween<T>(this IQueryable<T> source, T start, T end)
        {
            return source.Where(src => Comparer<T>.Default.Compare(src, start) >= 0 && Comparer<T>.Default.Compare(src, end) <= 0);
        }

        public static IQueryable<T> IsExclusivelyBetween<T>(this IQueryable<T> source, T start, T end)
        {
            return source.Where(src => Comparer<T>.Default.Compare(src, start) > 0 && Comparer<T>.Default.Compare(src, end) < 0);
        }
    }
}
