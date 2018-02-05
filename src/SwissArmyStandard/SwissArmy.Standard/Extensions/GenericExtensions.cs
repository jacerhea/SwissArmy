using System.Collections.Generic;

namespace SwissArmy.Extensions
{
    public static class GenericExtensions
    {
        public static bool IsBetween<T>(this T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) >= 0
                && Comparer<T>.Default.Compare(item, end) <= 0;
        }

        public static bool IsExclusivelyBetween<T>(this T item, T start, T end)
        {
            return Comparer<T>.Default.Compare(item, start) > 0
                && Comparer<T>.Default.Compare(item, end) < 0;
        }
    }
}
