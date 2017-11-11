using System.Collections.Generic;
using System.Linq;

namespace SwissArmy.Extensions
{
    public static class GenericExtensions
    {
        public static bool IsBetween<T>(this T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) >= 0
                && Comparer<T>.Default.Compare(item, end) <= 0;
        }

        public static IQueryable<T> IsBetween<T>(this IQueryable<T> source, T start, T end)
        {
            return source.Where(src => Comparer<T>.Default.Compare(src, start) >= 0 && Comparer<T>.Default.Compare(src, end) <= 0);
        }

        public static bool IsExclusivelyBetween<T>(this T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) > 0
                && Comparer<T>.Default.Compare(item, end) < 0;
        }

        public static IQueryable<T> IsExclusivelyBetween<T>(this IQueryable<T> source, T start, T end)
        {
            return source.Where(src => Comparer<T>.Default.Compare(src, start) > 0 && Comparer<T>.Default.Compare(src, end) < 0);
        }
    }
}
